using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sokokapu_Stock_Management.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Specifications { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        //public string ImageThumnailUrl { get; set; }
        public bool InStock { get; set; }
        //public User AddedBy { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
