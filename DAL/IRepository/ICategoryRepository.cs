using Sokokapu_Stock_Management.Models;
using System.Collections.Generic;

namespace Sokokapu_Stock_Management.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories();
        Category GetCategoryById(int id);
        void Add(Category category);
        void Delete(int id);
        void Edit(Category category);
    }
}
