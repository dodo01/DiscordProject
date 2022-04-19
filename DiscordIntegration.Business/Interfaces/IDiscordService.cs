using System;
using System.Threading.Tasks;

namespace DiscordIntegration.Business.Interfaces
{
    public interface IDiscordService
    {
        Task SendBotMessage();
    }
}
