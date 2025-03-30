﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Variation : BaseEntity
    {
        public string? Name { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<VariationOption>? VariationOption { get; set; }
    }
}
