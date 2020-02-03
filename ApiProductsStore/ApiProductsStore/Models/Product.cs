using System;
using System.ComponentModel.DataAnnotations;

namespace ApiProductsStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string title { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string description { get; set; }

        [Required]
        public float prix { get; set; }

        
    }
}

