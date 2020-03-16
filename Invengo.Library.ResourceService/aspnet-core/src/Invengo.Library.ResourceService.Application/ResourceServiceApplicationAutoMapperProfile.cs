using AutoMapper;

namespace Invengo.Library.ResourceService
{
    public class ResourceServiceApplicationAutoMapperProfile : Profile
    {
        public ResourceServiceApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<DoubanBook, DoubanBookDto>();
            CreateMap<CreateUpdateDoubanBookDto, DoubanBook>();
        }
    }
}
