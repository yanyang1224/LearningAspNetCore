using Invengo.Library.ResourceService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Invengo.Library.ResourceService
{
    [DependsOn(
        typeof(ResourceServiceEntityFrameworkCoreTestModule)
        )]
    public class ResourceServiceDomainTestModule : AbpModule
    {

    }
}