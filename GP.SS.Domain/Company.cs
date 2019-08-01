using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_COMPANIES")]
    public class Company : DomainEntityBase
    {
        [Column("COMPANY_PROGRAM_ID")]
        public string CompanyProgramId { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("USERNAME")]
        public string Username { get; set; }

        [Column("SHORT_NAME")]
        public string ShortName { get; set; }

        [Column("FULL_NAME")]
        public string FullName { get; set; }

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

        public ICollection<Contractor> Contractors { get; set; }
    }
}
