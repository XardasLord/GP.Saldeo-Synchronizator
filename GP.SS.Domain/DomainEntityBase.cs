using System.ComponentModel.DataAnnotations;

namespace GP.SS.Domain
{
    public class DomainEntityBase
    {
        [Key]
        public string Id { get; set; }
    }
}