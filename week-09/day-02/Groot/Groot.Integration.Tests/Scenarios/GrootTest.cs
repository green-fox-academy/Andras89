using Groot.Integration.Tests.TestFixtures;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Groot.Integration.Tests
{
    public class GrootTest
    {
        private TestContext textFixture;

        public GrootTest()
        {
            textFixture = new TestContext();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await textFixture.Client.GetAsync("api/Guardian/groot");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootReturnOKWithParameter()
        {
            var response = await textFixture.Client.GetAsync("api/Guardian/groot?message=yolo");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
