using System.Xml.Serialization;

namespace GP.SS.Infrastructure.SaldeoSmart.ResponseModels
{
    [XmlRoot("RESPONSE")]
    public class ContractorsResponse
    {
        [XmlElement("STATUS")]
        public string Status { get; set; }

        [XmlElement("CONTRACTORS")]
        public Contractors Contractors { get; set; }
    }

    public class Contractors
    {
        [XmlElement("CONTRACTOR")]
        public Contractor[] ContractorsList { get; set; }
    }

    public class Contractor
    {
        [XmlElement("CONTRACTOR_PROGRAM_ID")]
        public string ContractorProgramId { get; set; }

        [XmlElement("CONTRACTOR_ID")]
        public string ContractorId { get; set; }

        [XmlElement("SHORT_NAME")]
        public string ShortName { get; set; }

        [XmlElement("FULL_NAME")]
        public string FullName { get; set; }

        [XmlElement("SUPPLIER")]
        public bool IsSupplier { get; set; }

        [XmlElement("CUSTOMER")]
        public bool IsCustomer { get; set; }

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

        [XmlElement("EMAILS")]
        public Emails[] Emails { get; set; }
    }

    public class Emails
    {
        [XmlElement("EMAIL")]
        public string Email { get; set; }
    }
}