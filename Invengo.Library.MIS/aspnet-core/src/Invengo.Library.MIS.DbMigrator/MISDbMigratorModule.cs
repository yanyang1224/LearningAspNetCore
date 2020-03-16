using Invengo.Library.MIS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Invengo.Library.MIS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MISEntityFrameworkCoreDbMigrationsModule),
        typeof(MISApplicationContractsModule)
        )]
    public class MISDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
