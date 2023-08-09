using Microsoft.EntityFrameworkCore;
using Sabujcha.Models;

namespace Sabujcha.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsIcons> ProductsIcons { get; set; }

    }
}
