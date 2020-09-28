using System;
using System.ComponentModel.DataAnnotations;


namespace R1Services.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
