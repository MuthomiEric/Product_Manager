using Sokokapu_Stock_Management.Data.Interfaces;
using Sokokapu_Stock_Management.DBContext;
using Sokokapu_Stock_Management.Models;
using System.Collections.Generic;

namespace Sokokapu_Stock_Management.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductManagerDbContext _productManagerDbContext;

        public CategoryRepository(ProductManagerDbContext productManagerDbContext)
        {
            _productManagerDbContext = productManagerDbContext;
        }

        public IEnumerable<Category> Categories()
        {
            return _productManagerDbContext.Categories;
        }


    }
}
