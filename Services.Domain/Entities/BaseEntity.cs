﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Services.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
