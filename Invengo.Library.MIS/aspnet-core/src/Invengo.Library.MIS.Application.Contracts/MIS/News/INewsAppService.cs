using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Invengo.Library.MIS.MIS
{
    public interface INewsAppService 
        : ICrudAppService< // Defines CRUD methods
            NewsDto, // Used to show
            Guid, // Primary key
            PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of attachment
            CreateUpdateNewsDto, // Used to create
            CreateUpdateNewsDto> // Used to update
    {
    }
}
