using System.Threading.Tasks;

namespace Invengo.Library.MIS.Data
{
    public interface IMISDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
