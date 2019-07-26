﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("Saldeo_DocumentItems")]
    public class DocumentItem
    {
        [Key]
        public string Id { get; set; }
        public string Rate { get; set; }
        public string Netto { get; set; }
        public string Vat { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        [ForeignKey("FK_Saldeo_DocumentItems_Saldeo_Documents_DocumentId")]
        public string DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}