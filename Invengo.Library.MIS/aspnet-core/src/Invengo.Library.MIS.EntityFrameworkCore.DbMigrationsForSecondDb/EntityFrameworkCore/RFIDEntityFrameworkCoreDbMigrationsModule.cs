using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Invengo.Library.MIS.EntityFrameworkCore.DbMigrationsForSecondDb.EntityFrameworkCore
{
    [DependsOn(
        typeof(MISEntityFrameworkCoreModule)
        )]
    public class RFIDEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<RFIDMigrationsDbContext>();
        }
    }
}
