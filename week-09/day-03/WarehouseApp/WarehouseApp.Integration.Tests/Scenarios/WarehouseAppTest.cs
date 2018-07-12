using System;
using System.Net;
using System.Threading.Tasks;
using WarehouseApp.Integration.Tests.TestFixtures;
using Xunit;

namespace WarehouseApp.Integration.Tests
{
    public class WarehouseAppTest
    {
        private TestContext testFixture;

        public WarehouseAppTest()
        {
            testFixture = new TestContext();
        }

        [Fact]
        public async Task ReturnOkResult()
        {
            var response = await testFixture.Client.GetAsync("/shoppingplanner/warehouse/summary/query");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


    }
}
