using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Invengo.Library.MIS.EntityFrameworkCore.DbMigrationsForSecondDb.EntityFrameworkCore
{
    [ConnectionStringName("RFID")]
    public class RFIDMigrationsDbContext : AbpDbContext<RFIDMigrationsDbContext>
    {
        public RFIDMigrationsDbContext(
            DbContextOptions<RFIDMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigureRFID();
        }
    }
}
