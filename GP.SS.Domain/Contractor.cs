using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_CONTRACTORS")]
    public class Contractor : DomainEntityBase
    {
        [Column("COMPANY_PROGRAM_ID")]
        public string CompanyProgramId { get; set; }
        
        [Column("SHORT_NAME")]
        public string ShortName { get; set; }

        [Column("FULL_NAME")]
        public string FullName { get; set; }

        [Column("IS_SUPPLIER")]
        public bool IsSupplier { get; set; }

        [Column("IS_CUSTOMER")]
        public bool IsCustomer { get; set; }

        [Column("VAT_NUMBER")]
        public string VatNumber { get; set; }

        [Column("CITY")]
        public string City { get; set; }

        [Column("POSTCODE")]
        public string Postcode { get; set; }

        [Column("STREET")]
        public string Street { get; set; }

        [Column("TELEPHONE")]
        public string Telephone { get; set; }

        [Column("EMAILS")]
        public string Emails { get; set; }

        [ForeignKey("FK_Saldeo_Contractors_Saldeo_Companies_CompanyId")]
        [Column("COMPANY_ID")]
        public string CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}