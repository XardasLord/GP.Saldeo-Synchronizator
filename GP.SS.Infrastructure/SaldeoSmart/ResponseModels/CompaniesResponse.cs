using System.Xml.Serialization;

namespace GP.SS.Infrastructure.SaldeoSmart.ResponseModels
{
	[XmlRoot("RESPONSE")]
	public class CompaniesResponse
	{
		[XmlElement("STATUS")]
		public string Status { get; set; }

		[XmlElement("COMPANIES")]
		public Companies Companies { get; set; }
	}

	public class Companies
	{
		[XmlElement("COMPANY")]
		public Company[] Company { get; set; }
	}

	public class Company
	{
	    [XmlElement("COMPANY_PROGRAM_ID")]
		public string CompanyProgramId { get; set; }

		[XmlElement("COMPANY_ID")]
		public string CompanyId { get; set; }

		[XmlElement("EMAIL")]
		public string Email { get; set; }

		[XmlElement("USERNAME")]
		public string Username { get; set; }

		[XmlElement("SHORT_NAME")]
		public string ShortName { get; set; }

		[XmlElement("FULL_NAME")]
		public string FullName { get; set; }

		[XmlElement("VAT_NUMBER")]
		public string VatNumber { get; set; }

		[XmlElement("CITY")]
		public string City { get; set; }

		[XmlElement("POSTCODE")]
		public string Postcode { get; set; }

		[XmlElement("STREET")]
		public string Street { get; set; }

		[XmlElement("TELEPHONE")]
		public string Telephone { get; set; }
	}

}
