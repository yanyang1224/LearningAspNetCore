using Invengo.Library.MIS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Invengo.Library.MIS
{
    [DependsOn(
        typeof(MISEntityFrameworkCoreTestModule)
        )]
    public class MISDomainTestModule : AbpModule
    {

    }
}