using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_DOCUMENTS")]
    public class Document
    {
        [Key]
        [Column("DOCUMENT_ID")]
        public string Id { get; set; }

        [Column("DOCUMENT_NUMBER")]
        public string Number { get; set; }

        [Column("DOCUMENT_TYPE_NAME")]
        public string DocumentTypeName { get; set; }

        [Column("DOCUMENT_TYPE_SHORT_NAME")]
        public string DocumentTypeShortName { get; set; }

        [Column("COST_CATEGORY")]
        public string Category { get; set; }

        [Column("COST_CATEGORY_RODZAJ")]
        public string CategoryKind { get; set; }

        [Column("COST_CATEGORY_TYP")]
        public string CategoryType { get; set; }

        [Column("COST_CATEGORY_PODTYP")]
        public string CategorySubType { get; set; }

        [Column("COST_CATEGORY_OPIS")]
        public string CategoryDescription { get; set; }

        [Column("COST_DESCRIPTION")]
        public string Description { get; set; }

        [Column("DATE_ISSUE", TypeName = "DATE")]
        public DateTime? IssueDate { get; set; }

        [Column("DATE_SALE", TypeName = "DATE")]
        public DateTime? SaleDate { get; set; }

        [Column("DATE_PAYMENT", TypeName = "DATE")]
        public DateTime? PaymentDate { get; set; }

        [Column("DATE_RECEIVE", TypeName = "DATE")]
        public DateTime? ReceiveDate { get; set; }

        [Column("DOCUMENT_IS_PAID")]
        public bool IsDocumentPaid { get; set; }

        [Column("DOCUMENT_PAYMENT_TYPE")]
        public string PaymentType { get; set; }

        [Column("DOCUMENT_KWOTA_BRUTTO")]
        public decimal? Sum { get; set; }

        [Column("PROJECT_CODE")]
        public string ProjectCode { get; set; }

        [Column("PROJECT_CODE_COPY")]
        public string ProjectCodeCopy { get; set; }

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

        [Column("CONTRACTOR_TYP")]
        public string ContractorType { get; set; }

        [ForeignKey("FK_Saldeo.Documents_Saldeo.Companies_CompanyId")]
        [Column("COMPANY_ID")]
        public string CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public ICollection<DocumentVatRegistry> DocumentVatRegistries { get; set; }
        public ICollection<DocumentItem> DocumentItems { get; set; }
    }
}