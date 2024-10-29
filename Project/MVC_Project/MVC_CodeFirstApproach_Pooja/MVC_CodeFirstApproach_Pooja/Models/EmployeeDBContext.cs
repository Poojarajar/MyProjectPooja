using Microsoft.EntityFrameworkCore;

namespace MVC_CodeFirstApproach_Pooja.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options): base(options)
        {

        }

        public DbSet<EmployeeModel> employees { get; set; }
    }
}
