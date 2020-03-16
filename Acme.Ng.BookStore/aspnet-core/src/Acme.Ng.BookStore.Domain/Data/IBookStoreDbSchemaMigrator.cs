using System.Threading.Tasks;

namespace Acme.Ng.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
