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

        public IEnumerable<Category> AllCategories()
        {
            return _productManagerDbContext.Categories
                .Include(c => c.Products);
        }


        public void Delete(int id)
        {
            var cat = GetCategoryById(id);
            _productManagerDbContext.Remove(cat);
            _productManagerDbContext.SaveChanges();
        }

        public void Edit(Category category)
        {
            _productManagerDbContext.Categories.Update(category);
            _productManagerDbContext.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            return _productManagerDbContext.Categories
                .Include(p => p.Products)
                 .FirstOrDefault(c => c.Id == id);
        }


    }
}
