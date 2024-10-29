using Microsoft.EntityFrameworkCore;

namespace MVC_CodeFirstApproach1.Models
{
        public class AppDbContext : DbContext
        {
            public DbSet<ProductModel> Products { get; set; }
            public DbSet<CategoryModel> Categories { get; set; }

            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }
        }
}
