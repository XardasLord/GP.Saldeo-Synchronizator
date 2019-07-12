using System.Xml.Serialization;

namespace GP.SS.Infrastructure.SaldeoSmart.ResponseModels
{
	[XmlRoot("RESPONSE")]
	public class CompaniesResponse
	{
		[XmlElement("STATUS")]
		public string STATUS { get; set; }

		[XmlElement("COMPANIES")]
		public COMPANIES COMPANIES { get; set; }
	}

	public class COMPANIES
	{
		[XmlElement("COMPANY")]
		public COMPANY[] COMPANY { get; set; }
	}

	public class COMPANY
	{
		[XmlElement("COMPANY_PROGRAM_ID")]
		public string COMPANY_PROGRAM_ID { get; set; }

		[XmlElement("COMPANY_ID")]
		public string COMPANY_ID { get; set; }

		[XmlElement("EMAIL")]
		public string EMAIL { get; set; }

		[XmlElement("USERNAME")]
		public string USERNAME { get; set; }

		[XmlElement("SHORT_NAME")]
		public string SHORT_NAME { get; set; }

		[XmlElement("FULL_NAME")]
		public string FULL_NAME { get; set; }

		[XmlElement("VAT_NUMBER")]
		public string VAT_NUMBER { get; set; }

		[XmlElement("CITY")]
		public string CITY { get; set; }

		[XmlElement("POSTCODE")]
		public string POSTCODE { get; set; }

		[XmlElement("STREET")]
		public string STREET { get; set; }

		[XmlElement("TELEPHONE")]
		public string TELEPHONE { get; set; }
	}

}
