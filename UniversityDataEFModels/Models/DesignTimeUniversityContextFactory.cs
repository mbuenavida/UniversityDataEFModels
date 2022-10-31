using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace UniversityDataEFModels.Models
{
    public class DesignTimeUniversityContextFactory : IDesignTimeDbContextFactory<UniversityContext>
    {
        public UniversityContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<UniversityContext>();

            // this connection string is for local SQL database 
            // This database instance is generally installed with default Visual Studio components
            // If you use SQL Server Express, change connection string appropriately
            // NOTE: Do not hardcode connection strings in code.  
            // This is hard coded here to limit scope of demo.
            var connectionString = "Data Source=MONICAIT;Initial Catalog=University; Integrated Security=True;";

            dbContextBuilder.UseSqlServer(connectionString, sqloptions => {
                sqloptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: new List<int>() { });
            });

            return new UniversityContext(dbContextBuilder.Options);
        }
    }
}
