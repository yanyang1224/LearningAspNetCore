using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.Repository
{
    public interface IMISRepository<TEntity,TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<TEntity> FirstOrDefaultAsync();
    }
}
