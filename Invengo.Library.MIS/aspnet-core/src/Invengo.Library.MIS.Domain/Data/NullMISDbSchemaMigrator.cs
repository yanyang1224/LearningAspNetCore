using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Invengo.Library.MIS.Data
{
    /* This is used if database provider does't define
     * IMISDbSchemaMigrator implementation.
     */
    public class NullMISDbSchemaMigrator : IMISDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}