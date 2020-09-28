using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace R1Services.Domain.Entities
{
    [Table("Contract")]
    public class Contract : BaseEntity
    {
        [Required]
        public bool Active { get; set; }
        
        public Guid ClientId { get; set; }

        public Guid ServiceId { get; set; }

        public Client Client { get; set; }

        public Service Service { get; set; }
    }
}