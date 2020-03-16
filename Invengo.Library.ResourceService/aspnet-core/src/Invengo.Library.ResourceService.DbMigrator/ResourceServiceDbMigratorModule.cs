using Invengo.Library.ResourceService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Invengo.Library.ResourceService.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ResourceServiceEntityFrameworkCoreDbMigrationsModule),
        typeof(ResourceServiceApplicationContractsModule)
        )]
    public class ResourceServiceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
