using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Invengo.Library.MIS.MIS
{
    public interface ITenantConfigAppService
        : ICrudAppService<
            TenantConfigDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateTenantConfigDto,
            CreateUpdateTenantConfigDto
            >
    {

    }
}
