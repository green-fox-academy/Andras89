using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WarehouseApp.Integration.Tests.TestFixtures
{
    public class TestContext
    {
        private TestServer server;
        public HttpClient Client { get; set; }

        public TestContext()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
