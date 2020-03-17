using Invengo.Library.MIS.EntityFrameworkCore.MIS;
using Invengo.Library.MIS.EntityFrameworkCore.RFID;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Invengo.Library.MIS.EntityFrameworkCore
{
    [DependsOn(
        typeof(MISEntityFrameworkCoreModule)
        )]
    public class MISEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ABPMigrationsDbContext>();
            context.Services.AddAbpDbContext<RFIDMigrationsDbContext>();
            context.Services.AddAbpDbContext<MISMigrationsDbContext>();
        }
    }
}
