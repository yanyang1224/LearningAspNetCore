using Volo.Abp.Modularity;

namespace Invengo.Library.MIS
{
    [DependsOn(
        typeof(MISApplicationModule),
        typeof(MISDomainTestModule)
        )]
    public class MISApplicationTestModule : AbpModule
    {

    }
}