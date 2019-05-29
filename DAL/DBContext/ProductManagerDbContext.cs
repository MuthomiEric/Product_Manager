using Microsoft.EntityFrameworkCore;
using Sokokapu_Stock_Management.Models;

namespace Sokokapu_Stock_Management.DBContext
{
    public class ProductManagerDbContext : DbContext
    {
        public ProductManagerDbContext(DbContextOptions<ProductManagerDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
