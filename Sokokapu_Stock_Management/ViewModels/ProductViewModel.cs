namespace Sokokapu_Stock_Management.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //private int Quantity { get; set; }
        public string Size { get; set; }
        public bool InStock { get; set; }

    }
}
