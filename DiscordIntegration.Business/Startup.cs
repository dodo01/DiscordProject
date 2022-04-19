using System;
using DiscordIntegration.Business.Interfaces;
using DiscordIntegration.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordIntegration.Business
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddScoped<IDiscordService, DiscordService>();
        }
    }
}
