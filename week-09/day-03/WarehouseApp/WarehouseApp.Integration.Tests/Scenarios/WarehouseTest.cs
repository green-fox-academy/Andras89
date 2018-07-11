using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using WarehouseApp.Integration.Tests.TestFixtures;
using Xunit;

namespace WarehouseApp.Integration.Tests
{
    public class WarehouseTest
    {
        private TestContext testFixture;

        public WarehouseTest()
        {
            testFixture = new TestContext();
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public async Task WarehouseRouteReturnOkResult()
        {
            var response = await testFixture.Client.GetAsync("shoppingplanner/warehouse");

            Assert.IsType<OkResult>(response);
        }

        [Fact]
        public async Task QueryRouteNoParameterReturnsSame()
        {
            var response = await testFixture.Client.GetAsync("shoppingplanner/warehouse/summary/query");

            Assert.Equal(JsonConvert.SerializeObject(new { result = "fail", clothes = "null" }),
                         response.Content.ReadAsStringAsync().Result);
        }
    }
}
