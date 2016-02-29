using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace InvoiceValidator
{
    public abstract class BaseValidator
	{
      protected readonly string WORKAREA = "./ValidatorXSD";

	  #region Fileds
	  protected string _schema;
	  protected string _xsdpath;
	  protected string _xmlpath;
	  protected string _xmlstring;
	  protected bool _isvalid;
	  protected List<string> _messages;
	  protected XmlDocument _xmldocument;
	  protected string _rootpath;
	  protected string _xmlfilename;	  
	  protected bool _fromfile;
	  #endregion

	  #region Properties
	  public bool IsValid { get { return _isvalid; } }
	  public string Schema { get { return _schema; } set { _schema = value; } }
	  public string XsdPath { get { return _xsdpath; } set { _xsdpath = value; } }
	  public string XmlPath { get { return _xmlpath; } set { _xmlpath = value; } }
	  public List<string> Messages { get { return _messages; } }
	  #endregion

	  #region Constructurs
      /// <summary>
      /// Deprecated.
      /// </summary>
	  public BaseValidator(string schema, string xsdpath, string xml) 
	  {
		_schema = schema;
		_xsdpath = xsdpath;		
		_messages = new List<string>();
		_rootpath = Path.GetDirectoryName(_xsdpath);	
		_isvalid = true;
        _messages = new List<string>();

		if (File.Exists(xml))
		{
		  _fromfile = true;
		  _xmlpath = xml;
		  _xmlfilename = Path.GetFileNameWithoutExtension(_xmlpath);
		}
		else
		{
		  _fromfile = false;
		  _xmlstring = xml; 
		}
	  }

      public BaseValidator(string xml)
      {
          _isvalid = true;
          _messages = new List<string>();

          if (File.Exists(xml))
          {
              _fromfile = true;
              _xmlpath = xml;
              _xmlfilename = Path.GetFileNameWithoutExtension(_xmlpath);
              _xmlstring = System.IO.File.ReadAllText(_xmlpath);
          }
          else
          {
              _fromfile = false;
              _xmlstring = xml;
          }
      }
	  #endregion

	  #region Validate
	  protected void ValidateInvoice(string schema, string xsdpath, string xml)
	  {
		XmlReader ToValidate = null;

		try
		{
		  XmlReaderSettings SettingsToCompare = new XmlReaderSettings();
		  SettingsToCompare.Schemas.Add(schema, xsdpath);         
		  SettingsToCompare.ValidationType = ValidationType.Schema;
		  SettingsToCompare.ValidationEventHandler += Settings_ValidationEventHandler;
		  ToValidate = XmlReader.Create(new StringReader(xml), SettingsToCompare);
		}
		catch (System.ArgumentNullException)
		{
		  throw new Exception("XSD missing");
		}

		try
		{		  
		  while (ToValidate.Read()) { }
		}
		catch (Exception E)
		{
		  _isvalid = false;
		  throw E;
		}		
	  }

      /// <summary>
      /// Validates an XML string with assigned schemas.
      /// </summary>
      /// <param name="schemas">Key-Value schemas</param>
      /// <param name="xmlstring">XML in string format.</param>
      protected void ValidateInvoice(List<KeyValuePair<string, string>> schemas, string xmlstring)
      {
          
          XmlReader ToValidate = null;

          try
          {
              XmlReaderSettings SettingsToCompare = new XmlReaderSettings();

              foreach (KeyValuePair<string, string> SchemaEntry in schemas)
              {
                  try
                  {
                      SettingsToCompare.Schemas.Add(SchemaEntry.Key, SchemaEntry.Value);
                  }
                  catch (System.Net.WebException)
                  {
                      string LocalXSD = WORKAREA + "/" + UrlSchemaToDirectoryName(SchemaEntry.Key) + "/" + Path.GetFileName(SchemaEntry.Value);

                      if (File.Exists(LocalXSD))
                          SettingsToCompare.Schemas.Add(SchemaEntry.Key, LocalXSD);
                      else
                      {
                          _isvalid = false;
                          _messages.Add("El esquema " + SchemaEntry.Value + "' no está diponible. Esto se debe a que tu conexión a internet está fallando o el esquema no es accesible de momento.");
                          return;
                      }
                  }
              }
             
              SettingsToCompare.ValidationType = ValidationType.Schema;
              SettingsToCompare.ValidationEventHandler += Settings_ValidationEventHandler;
              ToValidate = XmlReader.Create(new StringReader(xmlstring), SettingsToCompare);
          }
          catch (System.ArgumentNullException)
          {
              throw new Exception("XSD missing");
          }

          try
          {
              while (ToValidate.Read()) { }
          }
          catch (Exception E)
          {
              _isvalid = false;
              throw E;
          }
      }

	  protected void Settings_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
	  {
		if (e.Severity == XmlSeverityType.Warning)		
		  _messages.Add(String.Concat(XmlSeverityType.Warning.ToString(), ":", e.Message));		
		else if (e.Severity == XmlSeverityType.Error)
		{
          _messages.Add(String.Concat(XmlSeverityType.Error.ToString(), ":", e.Message));
		  _isvalid = false;
		}
	  }
	  #endregion

	  #region Generate
      /// <summary>
      /// Deprecated.
      /// </summary>
	  protected void CreateXmlDocument()
	  {
		if ((_xmlpath != null || _xmlstring != null) && _isvalid)
		{
		  _xmldocument = new XmlDocument();

		  if(_fromfile)
			_xmldocument.Load(_xmlpath);
		  else
			_xmldocument.LoadXml(_xmlstring);
		}
		else
		  throw new Exception("You must validate the invoice width Validate() method and the invoice must be valid.");
	  }

      protected void ParseToXmlDocument()
      {
          if (_xmlstring != null && _isvalid)
          {
              _xmldocument = new XmlDocument();

              if (_fromfile)
                  _xmldocument.Load(_xmlpath);
              else
                  _xmldocument.LoadXml(_xmlstring);
          }
          else
              throw new Exception("You must validate the invoice width Validate() method and the invoice must be valid.");
      }

	  public static object Deserialize(XmlDocument xml, Type type)
	  {
		XmlSerializer s = new XmlSerializer(type);
		string xmlString = xml.OuterXml.ToString();
		byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
		MemoryStream ms = new MemoryStream(buffer);
		XmlReader reader = new XmlTextReader(ms);
		object o = null;
		try
		{
		  o = s.Deserialize(reader);
		}
		finally
		{
		  reader.Close();
		}
		return o;
	  }
	  #endregion

      #region Helpers
      protected string UrlSchemaToDirectoryName(string urlschema)
      {
          string SchemaDirectoryName = String.Empty;

          if (urlschema.StartsWith("http://") || urlschema.StartsWith("https://"))
          {
              if (urlschema.StartsWith("http://"))
                  SchemaDirectoryName = urlschema.Substring("http://".Length);

              if (urlschema.StartsWith("https://"))
                  SchemaDirectoryName = urlschema.Substring("https://".Length);
          }

          return SchemaDirectoryName;
      }
      #endregion
    }
}
