using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.SS.Domain
{
    public class DomainEntityBase
    {
        [Key]
        [Column("ID")]
        public string Id { get; set; }
    }
}