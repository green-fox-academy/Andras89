using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Frontend.Integration.Tests.Fixtures
{
    public class TestContex
    {
        private TestServer server;

        public HttpClient Client { get; set; }

        public TestContex()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
