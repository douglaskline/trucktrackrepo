using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using System.Net;

namespace uitests
{
    public class RoutingTests
        :IClassFixture<WebApplicationFactory<ui.Startup>>
    {
        private readonly WebApplicationFactory<ui.Startup> _factory;

        public RoutingTests(WebApplicationFactory<ui.Startup> factory)
    
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Home/")]
        [InlineData("/Home/Nearby/70.0/70.0")]
        [InlineData("/Home/Truck/3/70.0/70.0")]
        [InlineData("/Home/Report/70.0/70.0")]
        [InlineData("/Home/Find/70.0/70.0")]
        public async Task EndpointsReturnSuccessAndCorrectType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8", 
                response.Content.Headers.ContentType.ToString());
            
        }
        [Theory]
        [InlineData("Home/Report/")]
        public async Task EndPointsProperlyReturnNotFound(string url)
        {
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);
            var actual = response.StatusCode;
            var expected = HttpStatusCode.NotFound;
            //Assert
            Assert.Equal(actual,expected);
            
        }
    }
}
