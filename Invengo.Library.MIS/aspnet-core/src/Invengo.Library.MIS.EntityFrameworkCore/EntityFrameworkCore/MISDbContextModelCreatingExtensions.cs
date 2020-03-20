using Invengo.Library.MIS.MIS;
using Invengo.Library.MIS.RFID;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace Invengo.Library.MIS.EntityFrameworkCore
{
    public static class MISDbContextModelCreatingExtensions
    {
        public static void ConfigureABP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MISConsts.DbTablePrefix + "YourEntities", MISConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureMIS(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Attachment>(b =>
            {
                b.ToTable("MisAttachment", MISConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<MediaInfo>(b =>
            {
                b.ToTable("MisMediaInfo", MISConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Activity>(b =>
            {
                b.ToTable("MisActivity", MISConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<News>(b =>
            {
                b.ToTable("MisNews", MISConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Template>(b =>
            {
                b.ToTable("MisTemplate", MISConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<TenantConfig>(b =>
            {
                b.ToTable("MisTenantConfig", MISConsts.DbSchema);
                b.ConfigureByConvention();
            });

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MISConsts.DbTablePrefix + "YourEntities", MISConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureRFID(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<BookInfo>(b =>
            {
                b.ToTable("BookInfo",MISConsts.DbSchema);
            });

            builder.Entity<BorrowHisIndex>(b =>
            {
                b.ToTable("BorrowHisIndex", MISConsts.DbSchema);
            });

            builder.Entity<BorrowHistory>(b =>
            {
                b.ToTable("BorrowHistory", MISConsts.DbSchema);
            });

            builder.Entity<CardType>(b =>
            {
                b.ToTable("CardType", MISConsts.DbSchema);
            });

            builder.Entity<CRD_TRANS_Recd>(b =>
            {
                b.ToTable("CRD_TRANS_Recd", MISConsts.DbSchema);
            });

            builder.Entity<DeviceInfo>(b =>
            {
                b.ToTable("DeviceInfo", MISConsts.DbSchema);
            });

            builder.Entity<duStaff>(b =>
            {
                b.ToTable("duStaff", MISConsts.DbSchema);
            });

            builder.Entity<JanitorLog>(b =>
            {
                b.ToTable("JanitorLog", MISConsts.DbSchema);
            });

            builder.Entity<Location>(b =>
            {
                b.ToTable("Location", MISConsts.DbSchema);
            });

            builder.Entity<Reader>(b =>
            {
                b.ToTable("Reader", MISConsts.DbSchema);
            });

            builder.Entity<ReaderINOUTLog>(b =>
            {
                b.ToTable("ReaderINOUTLog", MISConsts.DbSchema);
            });

            builder.Entity<VerifyIdentity>(b =>
            {
                b.ToTable("VerifyIdentity", MISConsts.DbSchema);
            });


            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MISConsts.DbTablePrefix + "YourEntities", MISConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}