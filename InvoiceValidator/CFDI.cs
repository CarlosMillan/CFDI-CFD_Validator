using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace InvoiceValidator
{
  public class CFDI : BaseValidator
  {
	#region Fileds
	private InvoiceValidator.CFDIClasses.Comprobante _comprobante;
	private readonly string TFD_SCHEMA = "http://www.sat.gob.mx/TimbreFiscalDigital";	
	private readonly string CFDI_SCHEMA = "http://www.sat.gob.mx/cfd/3";	
	private readonly string CFDI_COMPLEMENT_NODE = "cfdi:Complemento";
	private static readonly string CFDI_TFD_NODE = "tfd:TimbreFiscalDigital";
	private readonly string CFDI_ADDENDA_NODE = "cfdi:Addenda";
    private readonly string SCHEMA_LOCATION_REGEX  = "schemaLocation=\"[\\w:/.\\s]+\"";
	private string _xsdtfdpath;
	#endregion

	#region Properties
	public InvoiceValidator.CFDIClasses.Comprobante Comprobante { get { return _comprobante; } }
	public static string CFDI_TFD { get { return CFDI_TFD_NODE; } }
	#endregion

	#region Constructors	
    public CFDI(string xml)
        :base(xml)
    { 
    }

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/3. DEPRECATED
	/// </summary>
	/// <param name="xml">It can be either XML Path or XML String.</param>
	public CFDI(string xsdpath, string xsdtfdpath, string xml)
	  : base(null, xsdpath, xml)
	{
	  _schema = CFDI_SCHEMA;
	  this._xsdtfdpath = xsdtfdpath;
	}

	public CFDI(string xsdpath, string xml)
	  : this(xsdpath, null, xml)
	{
	  this._xsdtfdpath = null;
	}

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/3
	/// </summary>
	/// <param name="xml">It can be either XML Path or XML String.</param>
	public CFDI(string schema, string xsdpath, string xsdtfdpath, string xml)
	  : base(schema, xsdpath, xml) 
	{
	  this._xsdtfdpath = xsdtfdpath;
	}
	#endregion

	#region Public Methods
    /// <summary>
    /// Deprecated.
    /// </summary>
	public void Validate()
	{
	  try
	  {
		if (_schema != null && _xsdpath != null && (_xmlpath != null || _xmlstring != null))
		{
		  string XML = _xmlpath ?? _xmlstring;
		  XmlDocument XmlTmp = new XmlDocument();

		  if (_fromfile)
			XmlTmp.Load(XML);
		  else
			XmlTmp.LoadXml(XML);

		  if (!XmlTmp.DocumentElement.Prefix.Equals("cfdi"))
			throw new Exception(String.Concat("File '", _xmlfilename, "' is not a CFDI."));

		  XmlNodeList ComplementNode = XmlTmp.GetElementsByTagName(CFDI_COMPLEMENT_NODE);
		  XmlNodeList AddendaNode = XmlTmp.GetElementsByTagName(CFDI_ADDENDA_NODE);

		  #region Complement node
          if (ComplementNode.Count > 0)
          {
              XmlNodeList TfdNode = XmlTmp.GetElementsByTagName(CFDI_TFD_NODE);

              if (TfdNode.Count > 0)
                  ValidateInvoice(TFD_SCHEMA, this._xsdtfdpath, TfdNode[0].OuterXml);

              XmlTmp.DocumentElement.RemoveChild(ComplementNode[0]);
              XML = XmlTmp.InnerXml;
          }
		  #endregion 

		  #region Addenda node
		  if (AddendaNode.Count > 0)
		  {
			XmlTmp.DocumentElement.RemoveChild(AddendaNode[0]);
			XML = XmlTmp.InnerXml;
		  }
		  #endregion

		  if (_isvalid)
			ValidateInvoice(_schema, _xsdpath, XML);
		}
		else
		  throw new Exception("You must set a value for Schema, XsdPath and XmlPath variables.");
	  }
	  catch (Exception E)
	  {
		throw E;
	  }
	}

    public void InitialzeValidation()
    {
        try
        {
            if ( _xmlstring != null)
            {
                string XmlStringWithoutAddenda = RemoveAddenda(_xmlstring);
                List<KeyValuePair<string, string>> Schemas = new List<KeyValuePair<string,string>>();
                MatchCollection Locations = Regex.Matches(XmlStringWithoutAddenda, SCHEMA_LOCATION_REGEX);

                foreach(Match M in Locations)
                {
                    Match MValue = Regex.Match(M.Value, "\"[\\w:/.\\s-]+\"");
                    string SValue = MValue.Value.Substring(1, MValue.Value.Length - 2);
                    string[] SplitedValues = SValue.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                    if ((SplitedValues.Length % 2) == 0)
                    {
                        for (int i = 0; i < SplitedValues.Length; i++)
                            Schemas.Add(new KeyValuePair<string, string>(SplitedValues[i++], SplitedValues[i]));
                    }
                    else throw new Exception("Bad schema location values. It must be URL-SCHEMA URL-XSD format.");
                }

                SaveSchemasBackup(Schemas);
                ValidateInvoice(Schemas, XmlStringWithoutAddenda);
            }
            else
                throw new Exception("XML doesn´t exist.");
        }
        catch (Exception E)
        {
            throw E;
        }
    }

    private void SaveSchemasBackup(List<KeyValuePair<string, string>> schemas)
    {
        try
        {
            WebClient webClient = new WebClient();

            if(!Directory.Exists(WORKAREA))
                Directory.CreateDirectory(WORKAREA);

            foreach (KeyValuePair<string, string> schema in schemas)
            {
                string FileName = Path.GetFileName(schema.Value);
                string DirectoryName = UrlSchemaToDirectoryName(schema.Key);
                string DirectorySchema = WORKAREA + "/" + DirectoryName;
                string FullPath = DirectorySchema + "/" + FileName;

                if (!Directory.Exists(DirectorySchema))
                    Directory.CreateDirectory(DirectorySchema);

                if (!File.Exists(FullPath))
                    webClient.DownloadFile(schema.Value, FullPath);
            }
        }
        catch (Exception ex)
        {
            //throw ex;
        }
    }

    private string RemoveAddenda(string xml)
    {
        string FilteredXml = xml;

        try
        {
            XmlDocument XmlTmp = new XmlDocument();
            XmlTmp.LoadXml(xml);

            XmlNodeList AddendaNode = XmlTmp.GetElementsByTagName(CFDI_ADDENDA_NODE);

            #region Addenda node
            if (AddendaNode.Count > 0)
            {
                XmlTmp.DocumentElement.RemoveChild(AddendaNode[0]);
                FilteredXml = XmlTmp.InnerXml;
            }
            #endregion
        }
        catch { }

        return FilteredXml;
    }
    
    /// <summary>
    /// Deprecated
    /// </summary>
	public void Generate()	  
	{
	  try
	  {
		base.CreateXmlDocument();
		_comprobante = (InvoiceValidator.CFDIClasses.Comprobante)Deserialize(_xmldocument, typeof(InvoiceValidator.CFDIClasses.Comprobante));
	  }
	  catch(Exception E)
	  {
		_comprobante = null;
		throw E;
	  }
	}

    public void GenerateObj()
    {
        try
        {
            base.ParseToXmlDocument();
            _comprobante = (InvoiceValidator.CFDIClasses.Comprobante)Deserialize(_xmldocument, typeof(InvoiceValidator.CFDIClasses.Comprobante));
        }
        catch (Exception E)
        {
            _comprobante = null;
            throw E;
        }
    }
	#endregion
  }
}
