using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Invengo.Library.MIS.EntityFrameworkCore.MIS
{
    public class MISMigrationsDbContextFactory : IDesignTimeDbContextFactory<MISMigrationsDbContext>
    {
        public MISMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MISMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("MIS"));

            return new MISMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }

    }
}
