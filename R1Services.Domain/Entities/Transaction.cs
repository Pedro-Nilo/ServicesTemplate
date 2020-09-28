using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace R1Services.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        [Required]
        [Column(TypeName = "jsonb")]
        public string RequestData { get; set; }

        [Column(TypeName = "jsonb")]
        public string ResponseData { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Sender { get; set; }

        [Required]
        public bool ChargedBack { get; set; }

        public Guid ContractId { get; set; }

        public Contract Contract { get; set; }
    }
}