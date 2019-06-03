using Microsoft.EntityFrameworkCore;
using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.DBContext;
using Sokokapu_Stock_Management.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sokokapu_Stock_Management.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductManagerDbContext _productManagerDbContext;

        public ProductRepository(ProductManagerDbContext productManagerDbContext)
        {
            _productManagerDbContext = productManagerDbContext;
        }

        public void Add(Product product)
        {
            _productManagerDbContext.Products.Add(product);

            
            _productManagerDbContext.SaveChanges();


        }

        public IEnumerable<Product> AllProducts()
        {
            return _productManagerDbContext.Products.Include(c => c._Category);

        }

        public Category Category(int id)
        {
            return _productManagerDbContext.Products
                .Include(c => c._Category)
                .FirstOrDefault(p => p.Id == id)
                ._Category;
        }

        public void Delete(int id)
        {
            var prod = GetProductById(id);
            _productManagerDbContext.Products.Remove(prod);
            _productManagerDbContext.SaveChanges();

        }

        public void Edit(Product product)
        {
            _productManagerDbContext.Update(product);
            _productManagerDbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _productManagerDbContext.Products
                .Include(p => p._Category)
                .FirstOrDefault(p => p.Id == id);
        }


        public void Update(Product product)
        {

            //var _product = _productManagerDbContext.Products.Attach(product);
            //_product.State = EntityState.Modified;

            _productManagerDbContext.Update(product);
            _productManagerDbContext.SaveChanges();

        }
    }
}
