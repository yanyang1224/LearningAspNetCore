using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class NewsAppService
        : CrudAppService<
            News,
            NewsDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateNewsDto,
            CreateUpdateNewsDto>
        , INewsAppService
    {

        public NewsAppService(IRepository<News,Guid> newsRepository)
            : base(newsRepository)
        {

        }
    }
}
