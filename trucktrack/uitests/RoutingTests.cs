using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

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
        [InlineData("/Home/FindTruck/70.0/70.0")]

        public async Task EndpointsReturnSuccessAndCorrectType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            // System.Diagnostics.DebuggableAttribute.WriteLine("TEST--------------------");
            Assert.Equal("text/html; charset=utf-8", 
                response.Content.Headers.ContentType.ToString());
            
        }
    }
}
