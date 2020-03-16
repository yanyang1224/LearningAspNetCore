using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.Users;

namespace Invengo.Library.ResourceService.EntityFrameworkCore
{
    public static class ResourceServiceDbContextModelCreatingExtensions
    {
        public static void ConfigureResourceService(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ResourceServiceConsts.DbTablePrefix + "YourEntities", ResourceServiceConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureResService(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<ResNotFoundBook>(b =>
            {
                b.ToTable("ResNotFoundBook", ResourceServiceConsts.DbSchema);

                //...
            });

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ResourceServiceConsts.DbTablePrefix + "YourEntities", ResourceServiceConsts.DbSchema);

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