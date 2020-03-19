using System;
using System.Collections.Generic;
using System.Text;
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
        public ActivityAppService(IRepository<Activity,Guid> activityRepository)
            : base(activityRepository)
        {

        }
    }
}
