using AutoMapper;
using Invengo.Library.MIS.MIS;

namespace Invengo.Library.MIS
{
    public class MISApplicationAutoMapperProfile : Profile
    {
        public MISApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Attachment, AttachmentDto>();
            CreateMap<CreateUpdateAttachmentDto, Attachment>();

        }
    }
}
