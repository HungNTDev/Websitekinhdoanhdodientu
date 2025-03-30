﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Cart : BaseEntity
    {
        [ForeignKey("ApplicationUser")]
        public Guid UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
    }
}
