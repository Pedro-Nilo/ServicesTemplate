using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace R1Services.Domain.Entities
{
    [Table("Client")]
    public class Client : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(128)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        public string PasswordHash { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}