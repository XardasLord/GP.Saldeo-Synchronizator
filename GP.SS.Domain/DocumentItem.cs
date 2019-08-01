using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_DOCUMENT_ITEMS")]
    public class DocumentItem : DomainEntityBase
    {
        [Column("RATE")]
        public string Rate { get; set; }

        [Column("NETTO")]
        public string Netto { get; set; }

        [Column("VAT")]
        public string Vat { get; set; }

        [Column("CATEGORY")]
        public string Category { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [ForeignKey("FK_Saldeo_DocumentItems_Saldeo_Documents_DocumentId")]
        [Column("DOCUMENT_ID")]
        public string DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}