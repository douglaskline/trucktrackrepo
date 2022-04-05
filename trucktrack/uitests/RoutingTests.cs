using System;
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

        [Fact]
        public void Test1()
        {

        }
    }
}
