using System.Xml.Serialization;

namespace GP.SS.Infrastructure.SaldeoSmart.ResponseModels
{
    [XmlRoot("RESPONSE")]
    public class DocumentsResponse
    {
        [XmlElement("STATUS")]
        public string Status { get; set; }

        [XmlElement("ARTICLES")]
        public Articles Articles { get; set; }

        [XmlElement("CONTRACTORS")]
        public ContractorsOnDocument Contractors { get; set; }

        [XmlElement("DOCUMENTS")]
        public Documents Documents { get; set; }
    }

    public class Articles
    {
        [XmlElement("ARTICLE")]
        public Article[] ArticleList { get; set; }
    }

    public class Article
    {
        [XmlElement("ARTICLE_ID")]
        public string ArticleId { get; set; }

        [XmlElement("ARTICLE_PROGRAM_ID")]
        public string ArticleProgramId { get; set; }

        [XmlElement("CODE")]
        public string Code { get; set; }

        [XmlElement("NAME")]
        public string Name { get; set; }

        [XmlElement("UNIT")]
        public string Unit { get; set; }

        [XmlElement("PKWIU")]
        public string Pkwiu { get; set; }

        [XmlElement("FOR_INVOICES")]
        public string ForInvoices { get; set; }

        [XmlElement("FOR_DOCUMENTS")]
        public string ForDocuments { get; set; }

        [XmlElement("FOREIGN_CODES")]
        public ForeignCodes[] ForeignCodes { get; set; }
    }

    public class ForeignCodes
    {
        [XmlElement("FOREIGN_CODE")]
        public ForeignCode ForeignCode { get; set; }
    }

    public class ForeignCode
    {
        [XmlElement("CONTRACTOR_ID")]
        public string ContractorId { get; set; }

        [XmlElement("CODE")]
        public string Code { get; set; }
    }

    public class ContractorsOnDocument
    {
        [XmlElement("CONTRACTOR")]
        public ContractorOnDocument[] ContractorList { get; set; }
    }

    public class ContractorOnDocument
    {
        [XmlElement("CONTRACTOR_ID")]
        public string ContractorId { get; set; }

        [XmlElement("SHORT_NAME")]
        public string ShortName { get; set; }

        [XmlElement("FULL_NAME")]
        public string FullName { get; set; }

        [XmlElement("SUPPLIER")]
        public string IsSupplier { get; set; }

        [XmlElement("CUSTOMER")]
        public string IsCustomer { get; set; }

        [XmlElement("CITY")]
        public string City { get; set; }

        [XmlElement("POSTCODE")]
        public string Postcode { get; set; }

        [XmlElement("STREET")]
        public string Street { get; set; }

        [XmlElement("COUNTRY_ISO3166A2")]
        public string CountryIso3166A2 { get; set; }
    }

    public class Documents
    {
        [XmlElement("DOCUMENT")]
        public Document[] DocumentsList { get; set; }
    }

    public class Document
    {
        [XmlElement("DOCUMENT_ID")]
        public string DocumentId { get; set; }

        [XmlElement("NUMBER")]
        public string Number { get; set; }

        [XmlElement("ISSUE_DATE")]
        public string IssueDate { get; set; }

        [XmlElement("SALE_DATE")]
        public string SaleDate { get; set; }

        [XmlElement("PAYMENT_DATE")]
        public string PaymentDate { get; set; }

        [XmlElement("RECEIVE_DATE")]
        public string ReceiveDate { get; set; }

        [XmlElement("DOCUMENT_TYPE")]
        public DocumentType DocumentType { get; set; }

        [XmlElement("CLASSIFICATION")]
        public string Classification { get; set; }

        [XmlElement("CONTRACTOR")]
        public Contractor1 Contractor { get; set; }

        [XmlElement("FOLDER")]
        public Folder Folder { get; set; }

        [XmlElement("SUM")]
        public string Sum { get; set; }

        [XmlElement("VAT_REGISTRIES")]
        public VatRegistries VatRegistries { get; set; }

        [XmlElement("ITEMS")]
        public Items Items { get; set; }

        [XmlElement("CURRENCY_ISO4217")]
        public string CurrencyIso4217 { get; set; }

        [XmlElement("PAYMENT_TYPE")]
        public string PaymentType { get; set; }

        [XmlElement("STAGE")]
        public string Stage { get; set; }

        [XmlElement("SOURCE")]
        public string Source { get; set; }

        [XmlElement("DIMENSIONS")]
        public DIMENSIONS1 Dimensions { get; set; }

        [XmlElement("SALDEO_SYNC_DOCUMENTS")]
        public SALDEO_SYNC_DOCUMENTS SaldeoSyncDocuments { get; set; }

        [XmlElement("ATTACHMENTS")]
        public ATTACHMENTS Attachments { get; set; }

        [XmlElement("DOCUMENT_ITEMS")]
        public DOCUMENT_ITEMS DocumentItems { get; set; }

        [XmlElement("SEND_BY_USER")]
        public string SendByUser { get; set; }

        [XmlElement("IS_DOCUMENT_PAID")]
        public string IsDocumentPaid { get; set; }

        [XmlElement("DOCUMENT_PAYMENTS")]
        public DOCUMENT_PAYMENTS DocumentPayments { get; set; }

        [XmlElement("IS_DOCUMENT_BELONG_TO_COMPAN")]
        public string IsDocumentBelongToCompan { get; set; }
    }

    public class DocumentType
    {
        [XmlElement("ID")]
        public string Id { get; set; }

        [XmlElement("NAME")]
        public string Name { get; set; }

        [XmlElement("SHORT_NAME")]
        public string ShortName { get; set; }

        [XmlElement("TYPE")]
        public string Type { get; set; }
    }

    public class Contractor1
    {
        [XmlElement("CONTRACTOR_ID")]
        public string ContractorId { get; set; }
    }

    public class Folder
    {
        [XmlElement("MONTH")]
        public string Month { get; set; }

        [XmlElement("YEAR")]
        public string Year { get; set; }
    }

    public class VatRegistries
    {
        [XmlElement("VAT_REGISTRY")]
        public VatRegistry[] VatRegistry { get; set; }
    }

    public class VatRegistry
    {
        [XmlElement("RATE")]
        public string Rate { get; set; }

        [XmlElement("NETTO")]
        public string Netto { get; set; }

        [XmlElement("VAT")]
        public string Vat { get; set; }
    }

    public class Items
    {
        [XmlElement("ITEM")]
        public Item[] ItemsList { get; set; }
    }

    public class Item
    {
        [XmlElement("EXTRACTION")]
        public string Extraction { get; set; }

        [XmlElement("RATE")]
        public string Rate { get; set; }

        [XmlElement("NETTO")]
        public string Netto { get; set; }

        [XmlElement("VAT")]
        public string Vat { get; set; }

        [XmlElement("DIMENSIONS")]
        public DIMENSIONS Dimensions { get; set; }
    }

    public class DIMENSIONS
    {
        public object DIMENSION { get; set; }
    }

    public class DIMENSIONS1
    {
        public DIMENSION[] DIMENSION { get; set; }
    }

    public class DIMENSION
    {
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string ADDITIONAL_CODE { get; set; }
        public DIMENSION_VALUES DIMENSION_VALUES { get; set; }
    }

    public class DIMENSION_VALUES
    {
        public object DIMENSION_VALUE { get; set; }
    }

    public class SALDEO_SYNC_DOCUMENTS
    {
        public SALDEO_SYNC_DOCUMENT SALDEO_SYNC_DOCUMENT { get; set; }
    }

    public class SALDEO_SYNC_DOCUMENT
    {
        public string ID { get; set; }
        public string GUID { get; set; }
        public string DESCRIPTION { get; set; }
        public string NUMBERING_TYPE { get; set; }
        public string ACCOUNT_DOCUMENT_NUMBER { get; set; }
        public string DOCUMENT_STATUS { get; set; }
    }

    public class ATTACHMENTS
    {
        public ATTACHMENT[] ATTACHMENT { get; set; }
    }

    public class ATTACHMENT
    {
        public string ATTACHMENT_ID { get; set; }
        public string CREATE_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string FILENAME { get; set; }
        public string SOURCE { get; set; }
    }

    public class DOCUMENT_ITEMS
    {
        public DOCUMENT_ITEM[] DOCUMENT_ITEM { get; set; }
    }

    public class DOCUMENT_ITEM
    {
        public string ARTICLE_ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string AMOUNT { get; set; }
        public string UNIT { get; set; }
        public string RATE { get; set; }
        public string UNIT_VALUE { get; set; }
        public string NETTO { get; set; }
        public string VAT { get; set; }
        public string GROSS { get; set; }
    }

    public class DOCUMENT_PAYMENTS
    {
        public DOCUMENT_PAYMENT[] DOCUMENT_PAYMENT { get; set; }
    }

    public class DOCUMENT_PAYMENT
    {
        public string PAYMENT_DATE { get; set; }
        public string PAYMENT_AMOUNT { get; set; }
    }
}