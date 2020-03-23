
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Invengo.Library.MIS.Pages.MIS
{
    public class Index_Tests : MISWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/Activity");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
