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
	  protected readonly string WORKING_DIRECTORY = @"C:\ValidatorTmp";
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
	  public BaseValidator() :this(null, null, null){ }

	  public BaseValidator(string schema, string xsdpath, string xml) 
	  {
		_schema = schema;
		_xsdpath = xsdpath;		
		_messages = new List<string>();
		_rootpath = Path.GetDirectoryName(_xsdpath);
		_xmlfilename = Path.GetFileNameWithoutExtension(_xmlpath);		
		_isvalid = true;

		if (File.Exists(xml))
		{
		  _fromfile = true;
		  _xmlpath = xml;
		}
		else
		{
		  _fromfile = false;
		  _xmlstring = xml; 
		}

		try
		{
		  if (!System.IO.Directory.Exists(WORKING_DIRECTORY))
			System.IO.Directory.CreateDirectory(WORKING_DIRECTORY);
		  else
			ClearTemporalFiles();
		}
		catch { }
	  }
	  #endregion

	  #region Validate
	  protected void ValidateInvoice(string schema, string xsdpath, string xmlpath)
	  {
		XmlReaderSettings SettingsToCompare = new XmlReaderSettings();
		SettingsToCompare.Schemas.Add(schema, xsdpath);
		SettingsToCompare.ValidationType = ValidationType.Schema;
		SettingsToCompare.ValidationEventHandler += Settings_ValidationEventHandler;
		XmlReader ToValidate = XmlReader.Create(xmlpath, SettingsToCompare);

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

	  protected void ClearTemporalFiles()
	  { 
		try
		{
		  Array.ForEach(Directory.GetFiles(WORKING_DIRECTORY),
						delegate(string path) { File.Delete(path); });
		}
		catch { }		
	  }
	  #endregion

	  #region Generate
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
	}
}
