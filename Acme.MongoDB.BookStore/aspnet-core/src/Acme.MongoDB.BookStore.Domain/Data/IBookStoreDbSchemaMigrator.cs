using System.Threading.Tasks;

namespace Acme.MongoDB.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
