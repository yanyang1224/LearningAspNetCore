using System;
using System.Threading.Tasks;
using Invengo.Library.MIS.MIS;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Invengo.Library.MIS.EntityFrameworkCore.MIS
{
    public class ActivityRepositoryTests : MISEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Activity, Guid> _activityRepository;

        public ActivityRepositoryTests()
        {
            _activityRepository = GetRequiredService<IRepository<Activity, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
