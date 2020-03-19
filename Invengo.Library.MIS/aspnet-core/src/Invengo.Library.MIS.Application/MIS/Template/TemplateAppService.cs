using System;
using System.Linq;
using Volo.Abp.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class TemplateAppService
        : CrudAppService<
            Template,
            TemplateDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateTemplateDto,
            CreateUpdateTemplateDto>
        , ITemplateAppService
    {
        private readonly IRepository<Template, Guid> _templateRepository;

        public TemplateAppService(IRepository<Template,Guid> templateRepository)
            : base(templateRepository)
        {
            _templateRepository = templateRepository;
        }

        /// <summary>
        /// 获取到第一条
        /// </summary>
        /// <returns></returns>
        public async Task<TemplateDto> GetFirstOrDefaultAsync()
        {
            var query = _templateRepository
                .Select(t => ObjectMapper.Map<Template, TemplateDto>(t));

            return await AsyncQueryableExecuter.FirstOrDefaultAsync(query);
        }

    }
}
