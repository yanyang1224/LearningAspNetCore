using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Invengo.Library.ResourceService.EntityFrameworkCore
{
    [DependsOn(
        typeof(ResourceServiceEntityFrameworkCoreModule)
        )]
    public class ResourceServiceEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ResourceServiceMigrationsDbContext>();
        }
    }
}
