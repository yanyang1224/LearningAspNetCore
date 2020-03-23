using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Invengo.Library.MIS.MIS
{
    public class ActivityAppServiceTests : MISApplicationTestBase
    {
        private readonly IActivityAppService _activityAppService;

        public ActivityAppServiceTests()
        {
            _activityAppService = GetRequiredService<IActivityAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
