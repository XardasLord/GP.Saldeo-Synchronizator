using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_DOCUMENTS")]
    public class Document : DomainEntityBase
    {
        [Column("NUMER_DOK")]
        public string Number { get; set; }

        [Column("DOCUMENT_TYPE_NAME")]
        public string DocumentTypeName { get; set; }

        [Column("DOCUMENT_TYPE_SHORT_NAME")]
        public string DocumentTypeShortName { get; set; }

        [Column("CATEGORY")]
        public string Category { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("ISSUE_DATE")]
        public string IssueDate { get; set; }

        [Column("SALE_DATE")]
        public string SaleDate { get; set; }

        [Column("PAYMENT_DATE")]
        public string PaymentDate { get; set; }

        [Column("RECEIVE_DATE")]
        public string ReceiveDate { get; set; }

        [Column("IS_DOCUMENT_PAID")]
        public bool IsDocumentPaid { get; set; }

        [Column("PAYMENT_TYPE")]
        public string PaymentType { get; set; }

        [Column("SUM")]
        public string Sum { get; set; }

        [Column("PROJECT_CODE")]
        public string ProjectCode { get; set; }

        [Column("PROJECT_USER")]
        public string ProjectUser { get; set; }

        [Column("PROJECT_NAME")]
        public string ProjectName { get; set; }

        // Contractor's snapshot

        [Column("CONTRACTOR_SHORT_NAME")]
        public string ContractorShortName { get; set; }

        [Column("CONTRACTOR_FULL_NAME")]
        public string ContractorFullName { get; set; }

        [Column("CONTRACTOR_IS_SUPPLIER")]
        public bool ContractorIsSupplier { get; set; }

        [Column("CONTRACTOR_IS_CUSTOMER")]
        public bool ContractorIsCustomer { get; set; }

        [Column("CONTRACTOR_VAT_NUMBER")]
        public string ContractorVatNumber { get; set; }

        [Column("CONTRACTOR_CITY")]
        public string ContractorCity { get; set; }

        [Column("CONTRACTOR_POSTCODE")]
        public string ContractorPostcode { get; set; }

        [Column("CONTRACTOR_STREET")]
        public string ContractorStreet { get; set; }

        [Column("CONTRACTOR_TELEPHONE")]
        public string ContractorTelephone { get; set; }

        [ForeignKey("FK_Saldeo.Documents_Saldeo.Companies_CompanyId")]
        [Column("COMPANY_ID")]
        public string CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public ICollection<DocumentVatRegistry> DocumentVatRegistries { get; set; }
        public ICollection<DocumentItem> DocumentItems { get; set; }
    }
}