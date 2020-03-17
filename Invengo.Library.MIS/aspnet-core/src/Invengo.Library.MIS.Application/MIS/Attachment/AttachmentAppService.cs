using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class AttachmentAppService:
        CrudAppService<
            Attachment,
            AttachmentDto, // Used to show
            Guid, // Primary key
            PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of attachment
            CreateUpdateAttachmentDto, // Used to create
            CreateUpdateAttachmentDto>
    {
        private IRepository<Attachment, Guid> _attachmentRepository;

        public AttachmentAppService(IRepository<Attachment, Guid> attachmentRepository)
            : base(attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }
    }
}
