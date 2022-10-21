using Microsoft.EntityFrameworkCore;

namespace UniversityDataEFModels.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Module> Modules { get; set; } = null!;
    }
}
