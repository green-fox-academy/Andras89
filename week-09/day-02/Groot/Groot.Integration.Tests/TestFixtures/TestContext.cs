using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Groot.Integration.Tests.TestFixtures
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer server;

        public TestContext()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
