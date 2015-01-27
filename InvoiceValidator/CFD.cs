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
	/// /// <param name="xml">It can be either XML Path or XML String.</param>
	/// </summary>
	public CFD(string xsdpath, string xml)
	  : base(null, xsdpath, xml)
	{
	  _schema = CFDI_SCHEMA;
	}

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/2 and XsdPath is cfdv32.xsd
	/// <param name="xml">It can be either XML Path or XML String.</param>
	/// </summary>	
	public CFD(string xml)
	  : this(null, xml) 
	{
	  _xsdpath = CFDI_XSD;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="xml">It can be either XML Path or XML String.</param>
	public CFD(string schema, string xsdpath, string xml)
	  : base(schema, xsdpath, xml) {}
	#endregion

	#region Public Methods
	public void Validate()
	{
	  if (_schema != null && _xsdpath != null && (_xmlpath != null || _xmlstring != null))
	  {
		string XML = _xmlpath ?? _xmlstring;
		string CfdiTmpName = null;
		XmlDocument XmlTmp = new XmlDocument();

		if (_fromfile)
		  XmlTmp.Load(XML);
		else
		  XmlTmp.LoadXml(XML);

		XmlNodeList ComplementNode = XmlTmp.GetElementsByTagName(CFDI_COMPLEMENT_NODE);

		if (ComplementNode.Count > 0)
		{
		  CfdiTmpName = String.Concat("/", _xmlfilename, "tmp.xml");
		  ComplementNode[0].ParentNode.RemoveChild(ComplementNode[0]);
		  XML = String.Concat(WORKING_DIRECTORY, CfdiTmpName);
		  XmlTmp.Save(XML);
		}

		ValidateInvoice(_schema, _xsdpath, XML);
	  }
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
