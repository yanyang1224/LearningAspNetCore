using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Invengo.Library.ResourceService.Data;
using Volo.Abp.DependencyInjection;

namespace Invengo.Library.ResourceService.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreResServiceDbSchemaMigrator 
        : IResServiceDbSchemaMigrator, ITransientDependency
    {
        private readonly ResServiceMigrationsDbContext _dbContext;

        public EntityFrameworkCoreResServiceDbSchemaMigrator(ResServiceMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}