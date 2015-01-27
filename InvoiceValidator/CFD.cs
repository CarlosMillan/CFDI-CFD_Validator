using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace InvoiceValidator
{
  public class CFD : BaseValidator
  {
	#region Fileds
	private InvoiceValidator.CFDClasses.Comprobante _comprobante;		
	private readonly string CFDI_SCHEMA = "http://www.sat.gob.mx/cfd/2";
	private readonly string CFDI_XSD = "./ValidatorXSD/cfdv2.xsd";
	private readonly string CFDI_COMPLEMENT_NODE = "Complemento";	
	#endregion

	#region Properties
	public InvoiceValidator.CFDClasses.Comprobante Comprobante { get { return _comprobante; } }
	#endregion

	#region Constructors
	public CFD() :base() { }

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/2
	/// </summary>
	public CFD(string xsdpath, string xmlpath)
	  : base(null, xsdpath, xmlpath)
	{
	  _schema = CFDI_SCHEMA;
	}

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/2 and XsdPath is cfdv32.xsd
	/// </summary>	
	public CFD(string xmlpath)
	  : this(null, xmlpath) 
	{
	  _xsdpath = CFDI_XSD;
	}

	public CFD(string schema, string xsdpath, string xmlpath)
	  : base(schema, xsdpath, xmlpath) {}
	#endregion

	#region Public Methods
	public void Validate()
	{
	  string XMLPath = _xmlpath;
	  string CfdiTmpName = null;
	  XmlDocument XmlTmp = new XmlDocument();
	  XmlTmp.Load(_xmlpath);

	  XmlNodeList ComplementNode = XmlTmp.GetElementsByTagName(CFDI_COMPLEMENT_NODE);

	  if (ComplementNode.Count > 0)
	  {
		CfdiTmpName = String.Concat("/", _xmlfilename, "tmp.xml");
		ComplementNode[0].ParentNode.RemoveChild(ComplementNode[0]);
		XMLPath = String.Concat(WORKING_DIRECTORY, CfdiTmpName);
		XmlTmp.Save(XMLPath);
	  }

	  ValidateInvoice(_schema, _xsdpath, XMLPath);
	}

	public void Generate()
	{
	  try
	  {
		base.CreateXmlDocument();
		_comprobante = (InvoiceValidator.CFDClasses.Comprobante)Deserialize(_xmldocument, typeof(InvoiceValidator.CFDClasses.Comprobante));
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
