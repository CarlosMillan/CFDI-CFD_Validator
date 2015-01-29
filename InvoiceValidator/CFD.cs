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
	private readonly string CFD_SCHEMA = "http://www.sat.gob.mx/cfd/2";	
	private readonly string CFD_COMPLEMENT_NODE = "Complemento";	
	#endregion

	#region Properties
	public InvoiceValidator.CFDClasses.Comprobante Comprobante { get { return _comprobante; } }
	#endregion

	#region Constructors	
	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/2
	/// <param name="xml">It can be either XML Path or XML String.</param>
	/// </summary>
	public CFD(string xsdpath, string xml)
	  : base(null, xsdpath, xml)
	{
	  _schema = CFD_SCHEMA;	  
	}

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/2
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
		XmlDocument XmlTmp = new XmlDocument();

		if (_fromfile)
		  XmlTmp.Load(XML);
		else
		  XmlTmp.LoadXml(XML);

		XmlNodeList ComplementNode = XmlTmp.GetElementsByTagName(CFD_COMPLEMENT_NODE);

		if (ComplementNode.Count > 0)
		{
		  XmlTmp.DocumentElement.RemoveChild(ComplementNode[0]);
		  XML = XmlTmp.InnerXml;
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
