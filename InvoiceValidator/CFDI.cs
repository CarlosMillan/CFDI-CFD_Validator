﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InvoiceValidator
{
  public class CFDI : BaseValidator
  {
	#region Fileds
	private InvoiceValidator.CFDIClasses.Comprobante _comprobante;
	private readonly string TFD_SCHEMA = "http://www.sat.gob.mx/TimbreFiscalDigital";
	private readonly string TFD_XSD = "./ValidatorXSD/TimbreFiscalDigital.xsd";
	private readonly string CFDI_SCHEMA = "http://www.sat.gob.mx/cfd/3";
	private readonly string CFDI_XSD = "./ValidatorXSD/cfdv32.xsd";
	private readonly string CFDI_COMPLEMENT_NODE = "cfdi:Complemento";
	private readonly string CFDI_TFD_NODE = "tfd:TimbreFiscalDigital";
	#endregion

	#region Properties
	public InvoiceValidator.CFDIClasses.Comprobante Comprobante { get { return _comprobante; } } 
	#endregion

	#region Constructors
	public CFDI() :base() { }

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/3
	/// </summary>
	public CFDI(string xsdpath, string xmlpath)
	  : base(null, xsdpath, xmlpath)
	{
	  _schema = CFDI_SCHEMA;
	}

	/// <summary>
	/// By default Schema is http://www.sat.gob.mx/cfd/3 and XsdPath is cfdv32.xsd
	/// </summary>	
	public CFDI(string xmlpath)
	  : this(null, xmlpath) 
	{
	  _xsdpath = CFDI_XSD;
	}

	public CFDI(string schema, string xsdpath, string xmlpath)
	  : base(schema, xsdpath, xmlpath) {}
	#endregion

	#region Public Methods
	public void Validate()
	{
	  try
	  {
		if (_schema != null && _xsdpath != null && _xmlpath != null)
		{
		  string XMLPath = _xmlpath;
		  string CfdiTmpName = null;
		  string CfdiTfdTmpName = null;
		  XmlDocument XmlTmp = new XmlDocument();
		  XmlTmp.Load(_xmlpath);

		  if (!XmlTmp.DocumentElement.Prefix.Equals("cfdi"))
			throw new Exception(String.Concat("El archivi '", _xmlfilename, "' no es un CFDI."));

		  XmlNodeList ComplementNode = XmlTmp.GetElementsByTagName(CFDI_COMPLEMENT_NODE);

		  if (ComplementNode.Count > 0)
		  {
			CfdiTmpName = String.Concat("/", _xmlfilename, "tmp.xml");
			CfdiTfdTmpName = String.Concat("/", _xmlfilename, "tfdtmp.xml");
			XmlNodeList TfdNode = XmlTmp.GetElementsByTagName(CFDI_TFD_NODE);

			if (TfdNode.Count > 0)
			{
			  System.IO.File.WriteAllLines(String.Concat(WORKING_DIRECTORY, CfdiTfdTmpName), new string[] { TfdNode[0].OuterXml });
			  ValidateInvoice(TFD_SCHEMA, TFD_XSD, String.Concat(WORKING_DIRECTORY, CfdiTfdTmpName));
			}

			ComplementNode[0].ParentNode.RemoveChild(ComplementNode[0]);
			XMLPath = String.Concat(WORKING_DIRECTORY, CfdiTmpName);
			XmlTmp.Save(XMLPath);
		  }

		  if (_isvalid)
			ValidateInvoice(_schema, _xsdpath, XMLPath);
		}
		else
		  throw new Exception("You must set a value for Schema, XsdPath and XmlPath variables.");
	  }
	  catch (Exception E)
	  {
		throw E;
	  }
	}

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
	#endregion
  }
}
