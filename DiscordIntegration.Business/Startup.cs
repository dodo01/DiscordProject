using System;
using DiscordIntegration.Business.Interfaces;
using DiscordIntegration.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordIntegration.Business
{
    public class Startup
    {
        public DiscordIntegration.Integration.Startup IntegrationStartup = new Integration.Startup();
        public void ConfigureServices(IServiceCollection service)
        {
            IntegrationStartup.ConfigureServices(service);

            service.AddScoped<IDiscordService, DiscordService>();
        }
    }
}
