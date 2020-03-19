using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class TenantConfigAppService
        : CrudAppService<
            TenantConfig,
            TenantConfigDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateTenantConfigDto,
            CreateUpdateTenantConfigDto
            >
        , ITenantConfigAppService
    {
        public TenantConfigAppService(IRepository<TenantConfig, Guid> tenantConfigRepository)
            : base(tenantConfigRepository)
        {

        }



    }
}
