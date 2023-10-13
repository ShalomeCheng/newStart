using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using newStart.WebService;

namespace newStart.IntegrationTests
{
    public class DefaultWebAppTestFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseEnvironment("IntegrationTests")
                .ConfigureAppConfiguration(cfg => cfg
                    .AddInMemoryCollection(new Dictionary<string, string>() {
                        { "OverrideConfigKey:InnerKey", "value" }
                    })
                )
                .ConfigureServices(services =>
                {
                });
        }
    }
}
