using Acme.MongoDB.BookStore.MongoDB;
using Volo.Abp.Modularity;

namespace Acme.MongoDB.BookStore
{
    [DependsOn(
        typeof(BookStoreMongoDbTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}