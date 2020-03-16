using Microsoft.EntityFrameworkCore;
using Invengo.Library.ResourceService.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Invengo.Library.ResourceService.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See ResourceServiceMigrationsDbContext for migrations.
     */
    [ConnectionStringName("ResDB")]
    public class ResDbContext : AbpDbContext<ResDbContext>
    {
        public DbSet<ResNotFoundBook> NotFoundBooks { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside ResDbContextModelCreatingExtensions.ConfigureResourceService
         */

        public ResDbContext(DbContextOptions<ResDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<ResNotFoundBook>(b => {
                b.ToTable("ResNotFoundBook");
            });

            /* Configure your own tables/entities inside the ConfigureResourceService method */

            builder.ConfigureResService();
        }
    }
}
