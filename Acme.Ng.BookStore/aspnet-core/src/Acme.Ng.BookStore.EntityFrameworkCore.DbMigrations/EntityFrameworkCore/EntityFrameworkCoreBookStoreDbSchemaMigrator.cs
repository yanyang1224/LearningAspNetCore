﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Acme.Ng.BookStore.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Ng.BookStore.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreBookStoreDbSchemaMigrator 
        : IBookStoreDbSchemaMigrator, ITransientDependency
    {
        private readonly BookStoreMigrationsDbContext _dbContext;

        public EntityFrameworkCoreBookStoreDbSchemaMigrator(BookStoreMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}