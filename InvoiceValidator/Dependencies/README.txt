To generate File.cs from File.xsd you need to use following command:
> xsd.exe /c File.xsd

REMEMBER to modify the file CFDI-CFD_Validator\InvoiceValidator\App_Code\GeneratedCode\cfdv32.cs after generated

File contains a class seems to:

/***************************************** AUTO-GENERATED ************************************************************/
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
/********************************************************************************************************************/
/***************************************** MODIFIED CLASS************************************************************/
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
  	[System.ComponentModel.DesignerCategoryAttribute("code")]
 	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
	public partial class ComprobanteComplemento
  	{

		private System.Xml.XmlElement[] anyField;
		private TimbreFiscalDigital timbre;

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

		public TimbreFiscalDigital Timbre
		{
	  	  get
	             {
			System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
			System.Collections.Generic.List<System.Xml.XmlElement> ComplementNodeList = new System.Collections.Generic.List<System.Xml.XmlElement>(Any);

			if (ComplementNodeList.Exists(x => x.Name.Equals(CFDI.CFDI_TFD)))
			{		  
		  	   Doc.LoadXml(ComplementNodeList.Find(x => x.Name.Equals(CFDI.CFDI_TFD)).OuterXml);
		     	   this.timbre = (TimbreFiscalDigital)BaseValidator.Deserialize(Doc, typeof(TimbreFiscalDigital));
			}

			return this.timbre; 
	  	     }

	  	  set { this.timbre = value; }
		}
  	}
/********************************************************************************************************************/