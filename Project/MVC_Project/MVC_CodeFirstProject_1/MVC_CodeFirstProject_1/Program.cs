using Microsoft.EntityFrameworkCore;
using MVC_CodeFirstProject_1.Models;

namespace MVC_CodeFirstProject_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var cs = builder.Configuration.GetConnectionString("cs1");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(cs));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=ProductModels}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
