using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IRepository<News, Guid> _newsRepository;

        public NewsAppService(IRepository<News,Guid> newsRepository)
            : base(newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<List<NewsDto>> GetAllReleaseAsync(NewsType? newsType)
        {
            var query = _newsRepository
                .WhereIf(newsType != null, a => a.Type == newsType)
                .Where(a => a.Status == Status.Release)
                .Select(a => ObjectMapper.Map<News, NewsDto>(a));

            return await AsyncQueryableExecuter.ToListAsync(query);
        }
    }
}
