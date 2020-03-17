using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Invengo.Library.MIS.EntityFrameworkCore.MIS
{
    [ConnectionStringName("MIS")]
    public class MISMigrationsDbContext : AbpDbContext<MISMigrationsDbContext>
    {
        public MISMigrationsDbContext(
            DbContextOptions<MISMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigureMIS();
        }
    }
}
