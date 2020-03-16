using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.MongoDB;
using Volo.Abp.BackgroundJobs.MongoDB;
using Volo.Abp.FeatureManagement.MongoDB;
using Volo.Abp.Identity.MongoDB;
using Volo.Abp.IdentityServer.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;
using Volo.Abp.PermissionManagement.MongoDB;
using Volo.Abp.SettingManagement.MongoDB;
using Volo.Abp.TenantManagement.MongoDB;

namespace Invengo.Library.ResourceService.MongoDB
{
    [DependsOn(
        typeof(ResourceServiceDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class ResourceServiceMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<ResourceServiceMongoDbContext>(options =>
            {
                options.AddDefaultRepositories();
            });
        }
    }
}
