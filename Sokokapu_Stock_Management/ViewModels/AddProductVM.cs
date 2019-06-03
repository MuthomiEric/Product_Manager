using Microsoft.AspNetCore.Http;
using Sokokapu_Stock_Management.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sokokapu_Stock_Management.ViewModels
{
    public class AddProductVM
    {

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string Color { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int NumberSold { get; set; }
        public string Size { get; set; }

        public IFormFile Photo { get; set; }
        [Display(Name = "Category")]
        public virtual int CategoryId { get; set; }
        public virtual Category _Category { get; set; }
    }
}
