using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "The name of the product must be a minimum of 10 characters and a maximum of 60 characters.")]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(10000, MinimumLength = 20, ErrorMessage = "Description of the product must be a minimum of 20 characters and a maximum of 100 characters.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Specify Price.")]
        [Range(1, 10000)]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
