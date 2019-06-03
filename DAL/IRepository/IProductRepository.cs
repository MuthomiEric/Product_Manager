using Sokokapu_Stock_Management.Models;
using System.Collections.Generic;

namespace Sokokapu_Stock_Management.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts();
        Product GetProductById(int id);
        void Add(Product product);
       void Update(Product product);
        Category Category(int id);
        void Delete(int id);
        void Edit(Product product);
    }
}
