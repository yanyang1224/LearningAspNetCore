using Microsoft.EntityFrameworkCore;
using Invengo.Library.MIS.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;
using Invengo.Library.MIS.RFID;
using Invengo.Library.MIS.MIS;

namespace Invengo.Library.MIS.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See MISMigrationsDbContext for migrations.
     */
    [ConnectionStringName("MIS")]
    public class MISDbContext : AbpDbContext<MISDbContext>
    {
        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<MediaInfo> MediaInfos { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<Template> Templates { get; set; }

        public DbSet<TenantConfig> TenantConfigs { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside MISDbContextModelCreatingExtensions.ConfigureMIS
         */

        public MISDbContext(DbContextOptions<MISDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */


            /* Configure your own tables/entities inside the ConfigureMIS method */

            builder.ConfigureMIS();
        }
    }
}
