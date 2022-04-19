using System;
using System.Threading.Tasks;

namespace DiscordIntegration.Integration.Interfaces
{
    public interface IBotProxy
    {
        Task RunBot();
        Task RegisterCommands();
    }
}
