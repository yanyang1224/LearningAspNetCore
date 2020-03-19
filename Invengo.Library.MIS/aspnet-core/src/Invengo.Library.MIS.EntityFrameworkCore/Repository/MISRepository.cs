using Invengo.Library.MIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Invengo.Library.MIS.Repository
{
    public class MISRepository<TEntity,TKey> : EfCoreRepository<MISDbContext, TEntity, TKey>, IMISRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        public MISRepository(IDbContextProvider<MISDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<TEntity> FirstOrDefaultAsync()
        {
            return await DbContext.Set<TEntity>().FirstOrDefaultAsync();
        }
    }
}
