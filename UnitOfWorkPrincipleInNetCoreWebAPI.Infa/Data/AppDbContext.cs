using Microsoft.EntityFrameworkCore;
using UnitOfWorkPrincipleInNetCoreWebAPI.Core.Model;

namespace UnitOfWorkPrincipleInNetCoreWebAPI.Infa.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductBrand> ProductBrands { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
