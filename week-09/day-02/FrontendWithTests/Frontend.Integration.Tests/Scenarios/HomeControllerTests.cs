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

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(12)]
        [InlineData(1)]
        [InlineData(45)]
        public async Task DoublingReturnJsonResponse(int input)
        {
            var response = await testFixture.Client.GetAsync($"doubling?input={input}");

            Assert.Equal(JsonConvert.SerializeObject(new { received = input, result = input * 2 }).ToLower(),
                         response.Content.ReadAsStringAsync().Result.ToLower());
        }
    }
}
