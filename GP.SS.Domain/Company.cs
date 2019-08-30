using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_COMPANIES")]
    public class Company : DomainEntityBase
    {
        [Column("COMPANY_PROGRAM_ID")]
        public string CompanyProgramId { get; set; }

        [Column("COMPANY_EMAIL")]
        public string Email { get; set; }

        [Column("COMPANY_USERNAME")]
        public string Username { get; set; }

        [Column("COMPANY_SHORT_NAME")]
        public string ShortName { get; set; }

        [Column("COMPANY_FULL_NAME")]
        public string FullName { get; set; }

        [Column("COMPANY_VAT_NUMBER")]
        public string VatNumber { get; set; }

        [Column("COMPANY_CITY")]
        public string City { get; set; }

        [Column("COMPANY_POSTCODE")]
        public string Postcode { get; set; }

        [Column("COMPANY_STREET")]
        public string Street { get; set; }

        [Column("COMPANY_TELEPHONE")]
        public string Telephone { get; set; }

        public ICollection<Contractor> Contractors { get; set; }
    }
}
