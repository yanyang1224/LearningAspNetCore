using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Invengo.Library.MIS.MIS
{
    public interface ITemplateAppService
        : ICrudAppService<
            TemplateDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateTemplateDto,
            CreateUpdateTemplateDto
            >
    {

    }
}
