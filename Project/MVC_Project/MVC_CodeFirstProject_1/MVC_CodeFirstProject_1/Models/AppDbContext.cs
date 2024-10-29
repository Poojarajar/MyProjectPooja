using Microsoft.EntityFrameworkCore;

namespace MVC_CodeFirstProject_1.Models
{

        public class AppDbContext : DbContext
        {
            public DbSet<ProductModel> Products { get; set; }
            public DbSet<Category> Categories { get; set; }

            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }
        }

    
}
