using Volo.Abp.Modularity;

namespace Invengo.Library.ResourceService
{
    [DependsOn(
        typeof(ResourceServiceApplicationModule),
        typeof(ResourceServiceDomainTestModule)
        )]
    public class ResourceServiceApplicationTestModule : AbpModule
    {

    }
}