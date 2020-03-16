using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.ResourceService
{
    public class DoubanBookAppService :
        CrudAppService<DoubanBook, DoubanBookDto, Guid, PagedAndSortedResultRequestDto,
                            CreateUpdateDoubanBookDto, CreateUpdateDoubanBookDto>,
        IDoubanBookAppService
    {

        private readonly IDoubanBookManager _doubanBookManager;
        public DoubanBookAppService(
            IRepository<DoubanBook, Guid> repository,
            IDoubanBookManager doubanBookManager
            )
            : base(repository)
        {
            _doubanBookManager = doubanBookManager;
        }

        public async Task<string> GetBookByISBN(string isbn)
        {
            return await _doubanBookManager.GetBookByISBN(isbn);
        }
    }
}
