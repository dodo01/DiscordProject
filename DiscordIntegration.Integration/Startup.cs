using System;
using Discord.Commands;
using Discord.WebSocket;
using DiscordIntegration.Integration.Interfaces;
using DiscordIntegration.Integration.Proxy;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordIntegration.Integration
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddScoped<IBotProxy, BotProxy>();
            service.AddSingleton<DiscordSocketClient>();
            service.AddSingleton<CommandService>();
        }
    }
}
