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

        public string Color { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int NumberSold { get; set; }
        public bool InStock
        {
            get
            {
                var remain = Quantity - NumberSold;
                if (remain > 0)
                {
                    return true;
                }
                else
                    return false;
            }

        }
        public string Size { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual Category _Category { get; set; }

    }
}
