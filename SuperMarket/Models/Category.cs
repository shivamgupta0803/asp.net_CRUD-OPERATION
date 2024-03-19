using System;
using System.ComponentModel.DataAnnotations;

namespace SuperMarket.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string? Description { get; set; } = string.Empty;

    }
}
