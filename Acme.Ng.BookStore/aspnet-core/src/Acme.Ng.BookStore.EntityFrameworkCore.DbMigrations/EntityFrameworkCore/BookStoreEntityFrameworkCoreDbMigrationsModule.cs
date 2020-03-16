using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.Ng.BookStore.EntityFrameworkCore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreModule)
        )]
    public class BookStoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BookStoreMigrationsDbContext>();
        }
    }
}
