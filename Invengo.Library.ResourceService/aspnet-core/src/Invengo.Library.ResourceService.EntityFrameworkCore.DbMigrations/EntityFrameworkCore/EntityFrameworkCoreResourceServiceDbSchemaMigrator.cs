using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Invengo.Library.ResourceService.Data;
using Volo.Abp.DependencyInjection;

namespace Invengo.Library.ResourceService.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreResourceServiceDbSchemaMigrator 
        : IResourceServiceDbSchemaMigrator, ITransientDependency
    {
        private readonly ResourceServiceMigrationsDbContext _dbContext;

        public EntityFrameworkCoreResourceServiceDbSchemaMigrator(ResourceServiceMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}