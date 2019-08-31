using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("SALDEO_DOCUMENT_VAT_REGISTRIES")]
    public class DocumentVatRegistry : DomainEntityBase
    {
        [Column("RATE")]
        public string Rate { get; set; }

        [Column("NETTO")]
        public decimal? Netto { get; set; }

        [Column("VAT")]
        public decimal? Vat { get; set; }

        [ForeignKey("FK_Saldeo_DocumentVatRegistries_Saldeo_Documents_DocumentId")]
        [Column("DOCUMENT_ID")]
        public string DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}