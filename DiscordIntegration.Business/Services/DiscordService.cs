using System;
using System.Threading.Tasks;
using DiscordIntegration.Business.Interfaces;
using DiscordIntegration.Integration.Interfaces;

namespace DiscordIntegration.Business.Services
{
    public class DiscordService : IDiscordService
    {
        private IBotProxy _botProxy;

        public DiscordService(IBotProxy bot)
        {
            _botProxy = bot;
        }

        public async Task SendBotMessage()
        {
            await _botProxy.RunBot();
        }
    }
}
