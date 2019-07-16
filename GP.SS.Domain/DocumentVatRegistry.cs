using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    [Table("Saldeo.DocumentVatRegistries")]
    public class DocumentVatRegistry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Rate { get; set; }
        public string Netto { get; set; }
        public string Vat { get; set; }

        [ForeignKey("FK_Saldeo.DocumentVatRegistries_Saldeo.Documents_DocumentId")]
        public string DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}