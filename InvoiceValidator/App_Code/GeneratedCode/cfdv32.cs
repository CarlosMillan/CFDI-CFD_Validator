﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 

namespace InvoiceValidator.CFDIClasses
{
  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
  public partial class Comprobante
  {

	private ComprobanteEmisor emisorField;

	private ComprobanteReceptor receptorField;

	private ComprobanteConcepto[] conceptosField;

	private ComprobanteImpuestos impuestosField;

	private ComprobanteComplemento complementoField;

	private ComprobanteAddenda addendaField;

	private string versionField;

	private string serieField;

	private string folioField;

	private System.DateTime fechaField;

	private string selloField;

	private string formaDePagoField;

	private string noCertificadoField;

	private string certificadoField;

	private string condicionesDePagoField;

	private decimal subTotalField;

	private decimal descuentoField;

	private bool descuentoFieldSpecified;

	private string motivoDescuentoField;

	private string tipoCambioField;

	private string monedaField;

	private decimal totalField;

	private ComprobanteTipoDeComprobante tipoDeComprobanteField;

	private string metodoDePagoField;

	private string lugarExpedicionField;

	private string numCtaPagoField;

	private string folioFiscalOrigField;

	private string serieFolioFiscalOrigField;

	private System.DateTime fechaFolioFiscalOrigField;

	private bool fechaFolioFiscalOrigFieldSpecified;

	private decimal montoFolioFiscalOrigField;

	private bool montoFolioFiscalOrigFieldSpecified;

	public Comprobante()
	{
	  this.versionField = "3.2";
	}

	/// <comentarios/>
	public ComprobanteEmisor Emisor
	{
	  get
	  {
		return this.emisorField;
	  }
	  set
	  {
		this.emisorField = value;
	  }
	}

	/// <comentarios/>
	public ComprobanteReceptor Receptor
	{
	  get
	  {
		return this.receptorField;
	  }
	  set
	  {
		this.receptorField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable = false)]
	public ComprobanteConcepto[] Conceptos
	{
	  get
	  {
		return this.conceptosField;
	  }
	  set
	  {
		this.conceptosField = value;
	  }
	}

	/// <comentarios/>
	public ComprobanteImpuestos Impuestos
	{
	  get
	  {
		return this.impuestosField;
	  }
	  set
	  {
		this.impuestosField = value;
	  }
	}

	/// <comentarios/>
	public ComprobanteComplemento Complemento
	{
	  get
	  {
		return this.complementoField;
	  }
	  set
	  {
		this.complementoField = value;
	  }
	}

	/// <comentarios/>
	public ComprobanteAddenda Addenda
	{
	  get
	  {
		return this.addendaField;
	  }
	  set
	  {
		this.addendaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string version
	{
	  get
	  {
		return this.versionField;
	  }
	  set
	  {
		this.versionField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string serie
	{
	  get
	  {
		return this.serieField;
	  }
	  set
	  {
		this.serieField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string folio
	{
	  get
	  {
		return this.folioField;
	  }
	  set
	  {
		this.folioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public System.DateTime fecha
	{
	  get
	  {
		return this.fechaField;
	  }
	  set
	  {
		this.fechaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string sello
	{
	  get
	  {
		return this.selloField;
	  }
	  set
	  {
		this.selloField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string formaDePago
	{
	  get
	  {
		return this.formaDePagoField;
	  }
	  set
	  {
		this.formaDePagoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noCertificado
	{
	  get
	  {
		return this.noCertificadoField;
	  }
	  set
	  {
		this.noCertificadoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string certificado
	{
	  get
	  {
		return this.certificadoField;
	  }
	  set
	  {
		this.certificadoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string condicionesDePago
	{
	  get
	  {
		return this.condicionesDePagoField;
	  }
	  set
	  {
		this.condicionesDePagoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal subTotal
	{
	  get
	  {
		return this.subTotalField;
	  }
	  set
	  {
		this.subTotalField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal descuento
	{
	  get
	  {
		return this.descuentoField;
	  }
	  set
	  {
		this.descuentoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool descuentoSpecified
	{
	  get
	  {
		return this.descuentoFieldSpecified;
	  }
	  set
	  {
		this.descuentoFieldSpecified = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string motivoDescuento
	{
	  get
	  {
		return this.motivoDescuentoField;
	  }
	  set
	  {
		this.motivoDescuentoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string TipoCambio
	{
	  get
	  {
		return this.tipoCambioField;
	  }
	  set
	  {
		this.tipoCambioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Moneda
	{
	  get
	  {
		return this.monedaField;
	  }
	  set
	  {
		this.monedaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal total
	{
	  get
	  {
		return this.totalField;
	  }
	  set
	  {
		this.totalField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ComprobanteTipoDeComprobante tipoDeComprobante
	{
	  get
	  {
		return this.tipoDeComprobanteField;
	  }
	  set
	  {
		this.tipoDeComprobanteField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string metodoDePago
	{
	  get
	  {
		return this.metodoDePagoField;
	  }
	  set
	  {
		this.metodoDePagoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string LugarExpedicion
	{
	  get
	  {
		return this.lugarExpedicionField;
	  }
	  set
	  {
		this.lugarExpedicionField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string NumCtaPago
	{
	  get
	  {
		return this.numCtaPagoField;
	  }
	  set
	  {
		this.numCtaPagoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string FolioFiscalOrig
	{
	  get
	  {
		return this.folioFiscalOrigField;
	  }
	  set
	  {
		this.folioFiscalOrigField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string SerieFolioFiscalOrig
	{
	  get
	  {
		return this.serieFolioFiscalOrigField;
	  }
	  set
	  {
		this.serieFolioFiscalOrigField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public System.DateTime FechaFolioFiscalOrig
	{
	  get
	  {
		return this.fechaFolioFiscalOrigField;
	  }
	  set
	  {
		this.fechaFolioFiscalOrigField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool FechaFolioFiscalOrigSpecified
	{
	  get
	  {
		return this.fechaFolioFiscalOrigFieldSpecified;
	  }
	  set
	  {
		this.fechaFolioFiscalOrigFieldSpecified = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal MontoFolioFiscalOrig
	{
	  get
	  {
		return this.montoFolioFiscalOrigField;
	  }
	  set
	  {
		this.montoFolioFiscalOrigField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool MontoFolioFiscalOrigSpecified
	{
	  get
	  {
		return this.montoFolioFiscalOrigFieldSpecified;
	  }
	  set
	  {
		this.montoFolioFiscalOrigFieldSpecified = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteEmisor
  {

	private t_UbicacionFiscal domicilioFiscalField;

	private t_Ubicacion expedidoEnField;

	private ComprobanteEmisorRegimenFiscal[] regimenFiscalField;

	private string rfcField;

	private string nombreField;

	/// <comentarios/>
	public t_UbicacionFiscal DomicilioFiscal
	{
	  get
	  {
		return this.domicilioFiscalField;
	  }
	  set
	  {
		this.domicilioFiscalField = value;
	  }
	}

	/// <comentarios/>
	public t_Ubicacion ExpedidoEn
	{
	  get
	  {
		return this.expedidoEnField;
	  }
	  set
	  {
		this.expedidoEnField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlElementAttribute("RegimenFiscal")]
	public ComprobanteEmisorRegimenFiscal[] RegimenFiscal
	{
	  get
	  {
		return this.regimenFiscalField;
	  }
	  set
	  {
		this.regimenFiscalField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string rfc
	{
	  get
	  {
		return this.rfcField;
	  }
	  set
	  {
		this.rfcField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string nombre
	{
	  get
	  {
		return this.nombreField;
	  }
	  set
	  {
		this.nombreField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class t_UbicacionFiscal
  {

	private string calleField;

	private string noExteriorField;

	private string noInteriorField;

	private string coloniaField;

	private string localidadField;

	private string referenciaField;

	private string municipioField;

	private string estadoField;

	private string paisField;

	private string codigoPostalField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string calle
	{
	  get
	  {
		return this.calleField;
	  }
	  set
	  {
		this.calleField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noExterior
	{
	  get
	  {
		return this.noExteriorField;
	  }
	  set
	  {
		this.noExteriorField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noInterior
	{
	  get
	  {
		return this.noInteriorField;
	  }
	  set
	  {
		this.noInteriorField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string colonia
	{
	  get
	  {
		return this.coloniaField;
	  }
	  set
	  {
		this.coloniaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string localidad
	{
	  get
	  {
		return this.localidadField;
	  }
	  set
	  {
		this.localidadField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string referencia
	{
	  get
	  {
		return this.referenciaField;
	  }
	  set
	  {
		this.referenciaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string municipio
	{
	  get
	  {
		return this.municipioField;
	  }
	  set
	  {
		this.municipioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string estado
	{
	  get
	  {
		return this.estadoField;
	  }
	  set
	  {
		this.estadoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string pais
	{
	  get
	  {
		return this.paisField;
	  }
	  set
	  {
		this.paisField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string codigoPostal
	{
	  get
	  {
		return this.codigoPostalField;
	  }
	  set
	  {
		this.codigoPostalField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class t_InformacionAduanera
  {

	private string numeroField;

	private System.DateTime fechaField;

	private string aduanaField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string numero
	{
	  get
	  {
		return this.numeroField;
	  }
	  set
	  {
		this.numeroField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
	public System.DateTime fecha
	{
	  get
	  {
		return this.fechaField;
	  }
	  set
	  {
		this.fechaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string aduana
	{
	  get
	  {
		return this.aduanaField;
	  }
	  set
	  {
		this.aduanaField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class t_Ubicacion
  {

	private string calleField;

	private string noExteriorField;

	private string noInteriorField;

	private string coloniaField;

	private string localidadField;

	private string referenciaField;

	private string municipioField;

	private string estadoField;

	private string paisField;

	private string codigoPostalField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string calle
	{
	  get
	  {
		return this.calleField;
	  }
	  set
	  {
		this.calleField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noExterior
	{
	  get
	  {
		return this.noExteriorField;
	  }
	  set
	  {
		this.noExteriorField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noInterior
	{
	  get
	  {
		return this.noInteriorField;
	  }
	  set
	  {
		this.noInteriorField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string colonia
	{
	  get
	  {
		return this.coloniaField;
	  }
	  set
	  {
		this.coloniaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string localidad
	{
	  get
	  {
		return this.localidadField;
	  }
	  set
	  {
		this.localidadField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string referencia
	{
	  get
	  {
		return this.referenciaField;
	  }
	  set
	  {
		this.referenciaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string municipio
	{
	  get
	  {
		return this.municipioField;
	  }
	  set
	  {
		this.municipioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string estado
	{
	  get
	  {
		return this.estadoField;
	  }
	  set
	  {
		this.estadoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string pais
	{
	  get
	  {
		return this.paisField;
	  }
	  set
	  {
		this.paisField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string codigoPostal
	{
	  get
	  {
		return this.codigoPostalField;
	  }
	  set
	  {
		this.codigoPostalField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteEmisorRegimenFiscal
  {

	private string regimenField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Regimen
	{
	  get
	  {
		return this.regimenField;
	  }
	  set
	  {
		this.regimenField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteReceptor
  {

	private t_Ubicacion domicilioField;

	private string rfcField;

	private string nombreField;

	/// <comentarios/>
	public t_Ubicacion Domicilio
	{
	  get
	  {
		return this.domicilioField;
	  }
	  set
	  {
		this.domicilioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string rfc
	{
	  get
	  {
		return this.rfcField;
	  }
	  set
	  {
		this.rfcField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string nombre
	{
	  get
	  {
		return this.nombreField;
	  }
	  set
	  {
		this.nombreField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteConcepto
  {

	private object[] itemsField;

	private decimal cantidadField;

	private string unidadField;

	private string noIdentificacionField;

	private string descripcionField;

	private decimal valorUnitarioField;

	private decimal importeField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlElementAttribute("ComplementoConcepto", typeof(ComprobanteConceptoComplementoConcepto))]
	[System.Xml.Serialization.XmlElementAttribute("CuentaPredial", typeof(ComprobanteConceptoCuentaPredial))]
	[System.Xml.Serialization.XmlElementAttribute("InformacionAduanera", typeof(t_InformacionAduanera))]
	[System.Xml.Serialization.XmlElementAttribute("Parte", typeof(ComprobanteConceptoParte))]
	public object[] Items
	{
	  get
	  {
		return this.itemsField;
	  }
	  set
	  {
		this.itemsField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal cantidad
	{
	  get
	  {
		return this.cantidadField;
	  }
	  set
	  {
		this.cantidadField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string unidad
	{
	  get
	  {
		return this.unidadField;
	  }
	  set
	  {
		this.unidadField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noIdentificacion
	{
	  get
	  {
		return this.noIdentificacionField;
	  }
	  set
	  {
		this.noIdentificacionField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string descripcion
	{
	  get
	  {
		return this.descripcionField;
	  }
	  set
	  {
		this.descripcionField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal valorUnitario
	{
	  get
	  {
		return this.valorUnitarioField;
	  }
	  set
	  {
		this.valorUnitarioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal importe
	{
	  get
	  {
		return this.importeField;
	  }
	  set
	  {
		this.importeField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteConceptoComplementoConcepto
  {

	private System.Xml.XmlElement[] anyField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAnyElementAttribute()]
	public System.Xml.XmlElement[] Any
	{
	  get
	  {
		return this.anyField;
	  }
	  set
	  {
		this.anyField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteConceptoCuentaPredial
  {

	private string numeroField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string numero
	{
	  get
	  {
		return this.numeroField;
	  }
	  set
	  {
		this.numeroField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteConceptoParte
  {

	private t_InformacionAduanera[] informacionAduaneraField;

	private decimal cantidadField;

	private string unidadField;

	private string noIdentificacionField;

	private string descripcionField;

	private decimal valorUnitarioField;

	private bool valorUnitarioFieldSpecified;

	private decimal importeField;

	private bool importeFieldSpecified;

	/// <comentarios/>
	[System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
	public t_InformacionAduanera[] InformacionAduanera
	{
	  get
	  {
		return this.informacionAduaneraField;
	  }
	  set
	  {
		this.informacionAduaneraField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal cantidad
	{
	  get
	  {
		return this.cantidadField;
	  }
	  set
	  {
		this.cantidadField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string unidad
	{
	  get
	  {
		return this.unidadField;
	  }
	  set
	  {
		this.unidadField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string noIdentificacion
	{
	  get
	  {
		return this.noIdentificacionField;
	  }
	  set
	  {
		this.noIdentificacionField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string descripcion
	{
	  get
	  {
		return this.descripcionField;
	  }
	  set
	  {
		this.descripcionField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal valorUnitario
	{
	  get
	  {
		return this.valorUnitarioField;
	  }
	  set
	  {
		this.valorUnitarioField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool valorUnitarioSpecified
	{
	  get
	  {
		return this.valorUnitarioFieldSpecified;
	  }
	  set
	  {
		this.valorUnitarioFieldSpecified = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal importe
	{
	  get
	  {
		return this.importeField;
	  }
	  set
	  {
		this.importeField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool importeSpecified
	{
	  get
	  {
		return this.importeFieldSpecified;
	  }
	  set
	  {
		this.importeFieldSpecified = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteImpuestos
  {

	private ComprobanteImpuestosRetencion[] retencionesField;

	private ComprobanteImpuestosTraslado[] trasladosField;

	private decimal totalImpuestosRetenidosField;

	private bool totalImpuestosRetenidosFieldSpecified;

	private decimal totalImpuestosTrasladadosField;

	private bool totalImpuestosTrasladadosFieldSpecified;

	/// <comentarios/>
	[System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
	public ComprobanteImpuestosRetencion[] Retenciones
	{
	  get
	  {
		return this.retencionesField;
	  }
	  set
	  {
		this.retencionesField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
	public ComprobanteImpuestosTraslado[] Traslados
	{
	  get
	  {
		return this.trasladosField;
	  }
	  set
	  {
		this.trasladosField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal totalImpuestosRetenidos
	{
	  get
	  {
		return this.totalImpuestosRetenidosField;
	  }
	  set
	  {
		this.totalImpuestosRetenidosField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool totalImpuestosRetenidosSpecified
	{
	  get
	  {
		return this.totalImpuestosRetenidosFieldSpecified;
	  }
	  set
	  {
		this.totalImpuestosRetenidosFieldSpecified = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal totalImpuestosTrasladados
	{
	  get
	  {
		return this.totalImpuestosTrasladadosField;
	  }
	  set
	  {
		this.totalImpuestosTrasladadosField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool totalImpuestosTrasladadosSpecified
	{
	  get
	  {
		return this.totalImpuestosTrasladadosFieldSpecified;
	  }
	  set
	  {
		this.totalImpuestosTrasladadosFieldSpecified = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteImpuestosRetencion
  {

	private ComprobanteImpuestosRetencionImpuesto impuestoField;

	private decimal importeField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ComprobanteImpuestosRetencionImpuesto impuesto
	{
	  get
	  {
		return this.impuestoField;
	  }
	  set
	  {
		this.impuestoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal importe
	{
	  get
	  {
		return this.importeField;
	  }
	  set
	  {
		this.importeField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public enum ComprobanteImpuestosRetencionImpuesto
  {

	/// <comentarios/>
	ISR,

	/// <comentarios/>
	IVA,
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteImpuestosTraslado
  {

	private ComprobanteImpuestosTrasladoImpuesto impuestoField;

	private decimal tasaField;

	private decimal importeField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ComprobanteImpuestosTrasladoImpuesto impuesto
	{
	  get
	  {
		return this.impuestoField;
	  }
	  set
	  {
		this.impuestoField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal tasa
	{
	  get
	  {
		return this.tasaField;
	  }
	  set
	  {
		this.tasaField = value;
	  }
	}

	/// <comentarios/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal importe
	{
	  get
	  {
		return this.importeField;
	  }
	  set
	  {
		this.importeField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public enum ComprobanteImpuestosTrasladoImpuesto
  {

	/// <comentarios/>
	IVA,

	/// <comentarios/>
	IEPS,
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteComplemento
  {

	private System.Xml.XmlElement[] anyField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAnyElementAttribute()]
	public System.Xml.XmlElement[] Any
	{
	  get
	  {
		return this.anyField;
	  }
	  set
	  {
		this.anyField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public partial class ComprobanteAddenda
  {

	private System.Xml.XmlElement[] anyField;

	/// <comentarios/>
	[System.Xml.Serialization.XmlAnyElementAttribute()]
	public System.Xml.XmlElement[] Any
	{
	  get
	  {
		return this.anyField;
	  }
	  set
	  {
		this.anyField = value;
	  }
	}
  }

  /// <comentarios/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
  public enum ComprobanteTipoDeComprobante
  {

	/// <comentarios/>
	ingreso,

	/// <comentarios/>
	egreso,

	/// <comentarios/>
	traslado,
  }
}