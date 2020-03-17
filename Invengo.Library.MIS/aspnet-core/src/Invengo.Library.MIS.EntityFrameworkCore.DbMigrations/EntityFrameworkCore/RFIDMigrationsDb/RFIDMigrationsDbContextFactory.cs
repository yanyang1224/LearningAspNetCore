using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Invengo.Library.MIS.EntityFrameworkCore.RFID
{
    public class RFIDMigrationsDbContextFactory : IDesignTimeDbContextFactory<RFIDMigrationsDbContext>
    {
        public RFIDMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<RFIDMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("RFID"));

            return new RFIDMigrationsDbContext(builder.Options);
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
