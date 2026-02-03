using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CoFinanceControl.Infrastructure.Data
{
    //A factory é usada apenas em design-time (migrations) quando o EF não consegue criar o DbContext via DI.
    public sealed class CoFinanceDbContextFactory : IDesignTimeDbContextFactory<CoFinanceDbContext>
    {
        public CoFinanceDbContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(),
                "..", "CoFinanceControl.WebApi");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<CoFinanceDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new CoFinanceDbContext(optionsBuilder.Options);
        }
    }
}

