using Frontend.Integration.Tests.Fixtures;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.Integration.Tests.Scenarios
{
    public class HomeControllerTests
    {
        private readonly TestContex testFixture;

        public HomeControllerTests()
        {
            testFixture = new TestContex();
        }

        [Fact]
        public async Task DoublingReturnOkResponse()
        {
            var response = await testFixture.Client.GetAsync("doubling?input=3");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task DoublingReturnJsonResponse()
        {
            var response = await testFixture.Client.GetAsync("doubling?input=3");

            Assert.Equal(JsonConvert.SerializeObject(new { received = 3, result = 6 }).ToLower(),
                         response.Content.ReadAsStringAsync().Result.ToLower());
        }
    }
}
