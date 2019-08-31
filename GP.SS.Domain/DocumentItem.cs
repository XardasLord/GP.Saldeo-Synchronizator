using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_DOCUMENT_ITEMS")]
    public class DocumentItem : DomainEntityBase
    {
        [Column("COST_RATE")]
        public string Rate { get; set; }

        [Column("COST_NETTO")]
        public decimal? Netto { get; set; }

        [Column("COST_VAT")]
        public decimal? Vat { get; set; }

        [Column("COST_CATEGORY")]
        public string Category { get; set; }

        [Column("COST_DESCRIPTION")]
        public string Description { get; set; }

        [ForeignKey("FK_Saldeo_DocumentItems_Saldeo_Documents_DocumentId")]
        [Column("DOCUMENT_ID")]
        public string DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}