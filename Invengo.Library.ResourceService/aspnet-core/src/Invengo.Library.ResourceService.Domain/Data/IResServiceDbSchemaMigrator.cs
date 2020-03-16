using System.Threading.Tasks;

namespace Invengo.Library.ResourceService.Data
{
    public interface IResServiceDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
