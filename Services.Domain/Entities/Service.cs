using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Services.Domain.Entities
{
    [Table("Service")]
    public class Service : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}