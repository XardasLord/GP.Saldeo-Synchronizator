﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("Saldeo.Companies")]
    public class Company : DomainEntityBase
    {
        public string CompanyProgramId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string VatNumber { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public string Telephone { get; set; }

        public ICollection<Contractor> Contractors { get; set; }
    }
}
