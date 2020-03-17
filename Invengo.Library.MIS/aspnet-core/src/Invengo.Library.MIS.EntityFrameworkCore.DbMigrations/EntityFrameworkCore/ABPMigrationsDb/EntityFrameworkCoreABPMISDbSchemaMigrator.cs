using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Invengo.Library.MIS.Data;
using Volo.Abp.DependencyInjection;

namespace Invengo.Library.MIS.EntityFrameworkCore
{
    public class EntityFrameworkCoreABPMISDbSchemaMigrator
        : IMISDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreABPMISDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MISMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ABPMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}