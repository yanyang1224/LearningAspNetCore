using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Invengo.Library.MIS.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MISHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MISConsoleApiClientModule : AbpModule
    {
        
    }
}
