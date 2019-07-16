using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("Saldeo.Contractors")]
    public class Contractor : DomainEntityBase
    {
        public string ContractorProgramId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public bool IsSupplier { get; set; }
        public bool IsCustomer { get; set; }
        public string VatNumber { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public string Telephone { get; set; }
        public string Emails { get; set; }

        [ForeignKey("FK_Saldeo.Contractors_Saldeo.Companies_CompanyId")]
        public string CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}