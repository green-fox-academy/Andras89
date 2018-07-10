using Groot.Integration.Tests.TestFixtures;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Groot.Integration.Tests
{
    public class GrootTest
    {
        private TestContext testFixture;

        public GrootTest()
        {
            testFixture = new TestContext();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await testFixture.Client.GetAsync("api/Guardian/groot");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootReturnOKWithParameter()
        {
            var response = await testFixture.Client.GetAsync("api/Guardian/groot?message=yolo");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("yolo")]
        [InlineData("treeman")]
        [InlineData("space saga")]
        [InlineData("tree like entity")]
        public async Task GrootReturnsCorrectAnswerOnGivenParameter(string message)
        {
            var response = await testFixture.Client.GetAsync($"api/Guardian/groot?message={message}");

            Assert.Equal(JsonConvert.SerializeObject(new { received = message, translated = "I am Groot!" }),
                         response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task ShouldReturnNotOKStatusWithoutParameter()
        {
            var response = await testFixture.Client.GetAsync("api/Guardian/groot");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task ShouldReturnErrorMessageOnNoParameter()
        {
            var response = await testFixture.Client.GetAsync("api/Guardian/groot");

            Assert.Equal(JsonConvert.SerializeObject(new { error = "I am Groot!" }),
                         response.Content.ReadAsStringAsync().Result);
        }
    }
}
