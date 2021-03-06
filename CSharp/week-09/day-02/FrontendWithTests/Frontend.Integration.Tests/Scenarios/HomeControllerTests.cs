﻿using Frontend.Integration.Tests.Fixtures;
using Frontend.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
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

        [Fact]
        public async Task GreetingReturnIfNameIsNull()
        {
            var response = await testFixture.Client.GetAsync("greeter?title=student");

            Assert.Equal(JsonConvert.SerializeObject(new { error = "Please provide a name!" }),
                         response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task GreetingReturnIfTitleIsNull()
        {
            var response = await testFixture.Client.GetAsync("greeter?name=pete");

            Assert.Equal(JsonConvert.SerializeObject(new { error = "Please provide a title!" }),
                         response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("Pete", "Student")]
        [InlineData("Cheesus", "OurLordAndSaviour")]
        [InlineData("Mark", "Mentor")]
        [InlineData("Niki", "Sajt")]
        public async Task GreeterDynamicInputTesting(string name, string title)
        {
            var response = await testFixture.Client.GetAsync($"greeter?name={name}&title={title}");

            Assert.Equal(JsonConvert.SerializeObject(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" }),
                        response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("kuty")]
        [InlineData("alm")]
        [InlineData("andre")]
        public async Task AppendAInputGetsAppendAedRight(string appendable)
        {
            var response = await testFixture.Client.GetAsync($"appenda/{appendable}");

            Assert.Equal(JsonConvert.SerializeObject(new { appended = $"{appendable}a" }),
                         response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("sum")]
        public async Task DoUntilSumChecker(string what)
        {
            var body = JsonConvert.SerializeObject(new Until { until = 3 });

            var response = await testFixture.Client.PostAsync($"dountil/{what}", new StringContent(body, Encoding.UTF8, "application/json"));

            Assert.Equal(JsonConvert.SerializeObject(new { until = 3, result = 6 }),
                         response.Content.ReadAsStringAsync().Result);
        }
    }
}
