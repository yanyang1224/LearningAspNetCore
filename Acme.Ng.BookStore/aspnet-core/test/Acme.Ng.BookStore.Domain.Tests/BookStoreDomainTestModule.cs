using Acme.Ng.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Ng.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}