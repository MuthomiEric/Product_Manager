namespace Sokokapu_Stock_Management.ViewModels
{
    public class ProductViewModel
    {
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Remaining { get; set; }
        public int NumberSold { get; set; }
        public string Size { get; set; }
        public bool InStock { get; set; }

    }
}
