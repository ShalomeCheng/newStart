using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Travix.Common.Bootstrapper.Web;

namespace newStart.WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            this.configuration = configuration;
            this.webHostEnvironment = webHostEnvironment;
        }

        private readonly IConfiguration configuration;

        private readonly IWebHostEnvironment webHostEnvironment;

        public void ConfigureServices(IServiceCollection services)
        {
            services.BootstrapEndpointsWebApplication(
                webHostEnvironment,
                configuration,
                opt =>
                {
                    opt.ApplicationInformation.ApplicationName = "foo";
                    opt.ApplicationInformation.ApplicationGroup = "enosis";
                });
                //register views
                services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
        }
    }
}
