using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Invengo.Library.ResourceService
{
    public interface IDoubanBookManager : IDomainService
    {
        Task<string> GetBookByISBN(string isbn);
    }
}
