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

            CreateMap<News, NewsDto>();
            CreateMap<CreateUpdateNewsDto, News>();

            CreateMap<Activity, ActivityDto>();
            CreateMap<CreateUpdateActivityDto, Activity>();

            CreateMap<MediaInfo, MediaInfoDto>();
            CreateMap<CreateUpdateMediaInfoDto, MediaInfo>();

            CreateMap<Template, TemplateDto>();
            CreateMap<CreateUpdateTemplateDto, Template>();

            CreateMap<TenantConfig, TenantConfigDto>();
            CreateMap<CreateUpdateTenantConfigDto, TenantConfig>();


        }
    }
}
