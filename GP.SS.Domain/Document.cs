using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("Saldeo.Documents")]
    public class Document : DomainEntityBase
    {
        public string Number { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypeShortName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string IssueDate { get; set; }
        public string SaleDate { get; set; }
        public string PaymentDate { get; set; }
        public string ReceiveDate { get; set; }
        public bool IsDocumentPaid { get; set; }
        public string PaymentType { get; set; }
        public string Sum { get; set; }

        // Contractor's snapshot
        public string ContractorShortName { get; set; }
        public string ContractorFullName { get; set; }
        public bool ContractorIsSupplier { get; set; }
        public bool ContractorIsCustomer { get; set; }
        public string ContractorVatNumber { get; set; }
        public string ContractorCity { get; set; }
        public string ContractorPostcode { get; set; }
        public string ContractorStreet { get; set; }
        public string ContractorTelephone { get; set; }

        [ForeignKey("FK_Saldeo.Documents_Saldeo.Companies_CompanyId")]
        public string CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public ICollection<DocumentVatRegistry> DocumentVatRegistries { get; set; }
        public ICollection<DocumentItem> DocumentItems { get; set; }
    }
}