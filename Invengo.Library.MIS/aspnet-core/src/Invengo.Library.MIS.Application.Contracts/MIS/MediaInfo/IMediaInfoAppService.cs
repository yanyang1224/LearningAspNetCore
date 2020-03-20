using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Invengo.Library.MIS.MIS
{
    public interface IMediaInfoAppService
        : ICrudAppService< // Defines CRUD methods
            MediaInfoDto, // Used to show
            Guid, // Primary key
            PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of attachment
            CreateUpdateMediaInfoDto, // Used to create
            CreateUpdateMediaInfoDto> // Used to update
    {
    }
}
