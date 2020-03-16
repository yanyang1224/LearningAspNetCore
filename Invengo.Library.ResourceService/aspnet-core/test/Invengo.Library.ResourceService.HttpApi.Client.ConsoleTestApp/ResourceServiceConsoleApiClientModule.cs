using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Invengo.Library.ResourceService.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ResourceServiceHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ResourceServiceConsoleApiClientModule : AbpModule
    {
        
    }
}
