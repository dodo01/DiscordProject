using System;
using System.Threading.Tasks;
using Discord.Commands;
namespace DiscordIntegration.Infrastructure.Modules
{
    public class Commands: ModuleBase<SocketCommandContext>
    {
        [Command("Hello")]
        public async Task Ping()
        {
            await ReplyAsync("Hello! Robert is a sucker Liverpool fan. How are you?");
        }

        [Command("Suge-o")]
        public async Task Curse()
        {
            await ReplyAsync("Suge-o tu!");
        }
    }
}
