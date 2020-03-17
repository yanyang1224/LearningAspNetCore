using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Invengo.Library.MIS.MIS
{
    public interface IAttachmentAppService :
        ICrudAppService< // Defines CRUD methods
            AttachmentDto, // Used to show
            Guid, // Primary key
            PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of attachment
            CreateUpdateAttachmentDto, // Used to create
            CreateUpdateAttachmentDto> // Used to update
    {
    }
}
