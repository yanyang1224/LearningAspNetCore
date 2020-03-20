using Invengo.Library.MIS.MIS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace Invengo.Library.MIS.DataSeed
{
    public class MISDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Template, Guid> _templateRepository;
        private readonly IGuidGenerator _guidGenerator;

        public MISDataSeederContributor(
            IRepository<Template, Guid> templateRepository,
            IGuidGenerator guidGenerator)
        {
            _templateRepository = templateRepository;
            _guidGenerator = guidGenerator;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _templateRepository.GetCountAsync() > 0)
            {
                return;
            }

            await _templateRepository.InsertAsync(
                new Template(new Guid("79AC63F0-C015-423F-8932-08C94DB7B11D"),"Demo 1")
                {
                    Remark = "系统模板，不可更改！"
                }
                );

            await _templateRepository.InsertAsync(
                new Template(new Guid("53E07CC7-A69B-47A9-B48A-1A3AA98A132F"), "Demo 2")
                {
                    Remark = "系统模板，不可更改！"
                }
                );

            await _templateRepository.InsertAsync(
                new Template(new Guid("4116E235-A954-4476-88E1-41528FB2658D"), "Demo 3")
                {
                    Remark = "系统模板，不可更改！"
                }
                );
        }

    }
}
