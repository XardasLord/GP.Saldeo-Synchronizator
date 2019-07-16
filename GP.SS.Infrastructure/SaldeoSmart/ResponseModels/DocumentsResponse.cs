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
        public Dimensions1 Dimensions { get; set; }

        [XmlElement("SALDEO_SYNC_DOCUMENTS")]
        public SaldeoSyncDocuments SaldeoSyncDocuments { get; set; }

        [XmlElement("ATTACHMENTS")]
        public Attachments Attachments { get; set; }

        [XmlElement("DOCUMENT_ITEMS")]
        public DocumentItems DocumentItems { get; set; }

        [XmlElement("SEND_BY_USER")]
        public string SendByUser { get; set; }

        [XmlElement("IS_DOCUMENT_PAID")]
        public string IsDocumentPaid { get; set; }

        [XmlElement("DOCUMENT_PAYMENTS")]
        public DocumentPayments DocumentPayments { get; set; }

        [XmlElement("IS_DOCUMENT_BELONG_TO_COMPANY")]
        public string IsDocumentBelongToCompany { get; set; }
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
        public Dimensions Dimensions { get; set; }
    }

    public class Dimensions
    {
        [XmlElement("DIMENSION")] // TODO: ARRAY ?
        public object Dimension { get; set; }
    }

    public class Dimensions1
    {
        [XmlElement("DIMENSION")]
        public Dimension[] Dimension { get; set; }
    }

    public class Dimension
    {
        [XmlElement("CODE")]
        public string Code { get; set; }

        [XmlElement("NAME")]
        public string Name { get; set; }

        [XmlElement("TYPE")]
        public string Type { get; set; }

        [XmlElement("ADDITIONAL_CODE")]
        public string AdditionalCode { get; set; }

        [XmlElement("DIMENSION_VALUES")]
        public DimensionValues DimensionValues { get; set; }
    }

    public class DimensionValues
    {
        [XmlElement("DIMENSION_VALUE")] // TODO: ARRAY ?
        public object DimensionValue { get; set; }
    }

    public class SaldeoSyncDocuments
    {
        [XmlElement("SALDEO_SYNC_DOCUMENT")]
        public SaldeoSyncDocument[] SaldeoSyncDocumentList { get; set; }
    }

    public class SaldeoSyncDocument
    {
        [XmlElement("ID")]
        public string Id { get; set; }

        [XmlElement("GUID")]
        public string Guid { get; set; }

        [XmlElement("DESCRIPTION")]
        public string Description { get; set; }

        [XmlElement("NUMBERING_TYPE")]
        public string NumberingType { get; set; }

        [XmlElement("ACCOUNT_DOCUMENT_NUMBER")]
        public string AccountDocumentNumber { get; set; }

        [XmlElement("DOCUMENT_STATUS")]
        public string DocumentStatus { get; set; }
    }

    public class Attachments
    {
        [XmlElement("ATTACHMENT")]
        public Attachment[] AttachmentsList { get; set; }
    }

    public class Attachment
    {
        [XmlElement("ATTACHMENT_ID")]
        public string AttachmentId { get; set; }

        [XmlElement("CREATE_DATE")]
        public string CreateDate { get; set; }

        [XmlElement("DESCRIPTION")]
        public string Description { get; set; }

        [XmlElement("FILENAME")]
        public string Filename { get; set; }

        [XmlElement("SOURCE")]
        public string Source { get; set; }
    }

    public class DocumentItems
    {
        [XmlElement("DOCUMENT_ITEM")]
        public DocumentItem[] DocumentItem { get; set; }
    }

    public class DocumentItem
    {
        [XmlElement("ARTICLE_ID")]
        public string ArticleId { get; set; }

        [XmlElement("CODE")]
        public string Code { get; set; }

        [XmlElement("NAME")]
        public string Name { get; set; }

        [XmlElement("AMOUNT")]
        public string Amount { get; set; }

        [XmlElement("UNIT")]
        public string Unit { get; set; }

        [XmlElement("RATE")]
        public string Rate { get; set; }

        [XmlElement("UNIT_VALUE")]
        public string UnitValue { get; set; }

        [XmlElement("NETTO")]
        public string Netto { get; set; }

        [XmlElement("VAT")]
        public string Vat { get; set; }

        [XmlElement("GROSS")]
        public string Gross { get; set; }
    }

    public class DocumentPayments
    {
        [XmlElement("DOCUMENT_PAYMENT")]
        public DocumentPayment[] DocumentPaymentList { get; set; }
    }

    public class DocumentPayment
    {
        [XmlElement("PAYMENT_DATE")]
        public string PaymentDate { get; set; }

        [XmlElement("PAYMENT_AMOUNT")]
        public string PaymentAmount { get; set; }
    }
}