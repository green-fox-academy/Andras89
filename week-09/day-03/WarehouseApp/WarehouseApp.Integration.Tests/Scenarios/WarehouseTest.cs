using System;
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
    }
}
