using UniversityDataEFModels.Services;

namespace UniversityDataEFModels
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.            
            builder.Services.AddScoped<IRepositoryCourse, EFRepositoryCourse>();
            builder.Services.AddScoped<IRepositoryModule, EFRepositoryModule>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Shared/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Courses}/{action=Index}");

            app.Run();
        }
    }
}
