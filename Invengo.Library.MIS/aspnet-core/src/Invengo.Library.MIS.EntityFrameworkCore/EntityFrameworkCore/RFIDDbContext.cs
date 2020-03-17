using Microsoft.EntityFrameworkCore;
using Invengo.Library.MIS.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;
using Invengo.Library.MIS.RFID;

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
    [ConnectionStringName("RFID")]
    public class RFIDDbContext : AbpDbContext<RFIDDbContext>
    {
        public DbSet<BookInfo> BookInfos { get; set; }

        public DbSet<BorrowHisIndex> BorrowHisIndices { get; set; }

        public DbSet<BorrowHistory> BorrowHistories { get; set; }

        public DbSet<CardType> CardTypes { get; set; }

        public DbSet<CRD_TRANS_Recd> CRD_TRANS_Recds { get; set; }

        public DbSet<DeviceInfo> DeviceInfos { get; set; }

        public DbSet<duStaff> duStaffs { get; set; }

        public DbSet<JanitorLog> JanitorLogs { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Reader> Readers { get; set; }

        public DbSet<ReaderINOUTLog> ReaderINOUTLogs { get; set; }

        public DbSet<VerifyIdentity> VerifyIdentities { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside MISDbContextModelCreatingExtensions.ConfigureRFID
         */

        public RFIDDbContext(DbContextOptions<RFIDDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */


            /* Configure your own tables/entities inside the ConfigureMIS method */

            builder.ConfigureRFID();
        }
    }
}
