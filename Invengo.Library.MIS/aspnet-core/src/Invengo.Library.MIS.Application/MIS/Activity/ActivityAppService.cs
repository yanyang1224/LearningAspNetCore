using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class ActivityAppService
        : CrudAppService<
            Activity,
            ActivityDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateActivityDto,
            CreateUpdateActivityDto>
        , IActivityAppService
    {
        private readonly IRepository<Activity, Guid> _activityRepository;

        public ActivityAppService(IRepository<Activity,Guid> activityRepository)
            : base(activityRepository)
        {
            _activityRepository = activityRepository;
        }

        /// <summary>
        /// 获取所有发布的活动
        /// </summary>
        /// <returns></returns>
        public async Task<List<ActivityDto>> GetAllReleaseAsync()
        {
            var query = _activityRepository
                .Where(a => a.Status == Status.Release)
                .Select(a => ObjectMapper.Map<Activity, ActivityDto>(a));

            return await AsyncQueryableExecuter.ToListAsync(query);
        }
    }
}
