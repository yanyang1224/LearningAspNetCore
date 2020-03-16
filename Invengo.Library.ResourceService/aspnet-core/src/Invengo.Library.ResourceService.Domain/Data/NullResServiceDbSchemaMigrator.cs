using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Invengo.Library.ResourceService.Data
{
    /* This is used if database provider does't define
     * IResourceServiceDbSchemaMigrator implementation.
     */
    public class NullResServiceDbSchemaMigrator : IResServiceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}