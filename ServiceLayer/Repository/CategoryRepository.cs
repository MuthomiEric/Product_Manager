using Microsoft.EntityFrameworkCore;
using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.DBContext;
using Sokokapu_Stock_Management.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sokokapu_Stock_Management.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductManagerDbContext _productManagerDbContext;

        public CategoryRepository(ProductManagerDbContext productManagerDbContext)
        {
            _productManagerDbContext = productManagerDbContext;
        }

        public void Add(Category category)
        {
            _productManagerDbContext.Add(category);
            _productManagerDbContext.SaveChanges();
        }

        public IEnumerable<Category> Categories()
        {
            return _productManagerDbContext.Categories
                .Include(c => c.Products);
        }

        public void Edit(Category category)
        {
            _productManagerDbContext.Categories.Update(category);
            _productManagerDbContext.SaveChanges();
        }

        public Category FindCategoryById(int id)
        {
            return _productManagerDbContext.Categories
                 .FirstOrDefault(c => c.Id == id);
        }
    }
}
