using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordIntegration.Infrastructure.Modules;
using DiscordIntegration.Integration.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordIntegration.Integration.Proxy
{
    public class BotProxy : ModuleBase<SocketCommandContext>, IBotProxy
    {
        private DiscordSocketClient _client;
        private CommandService _commandService;
        private IServiceProvider _serviceProvider;
        private string _botToken = "OTY2MDQ1MTc1Mjc1MjI1MTU4.Yl8Brg.05gNhZXsMqQxxJx-mGY-CIpZtAA";

        public BotProxy(DiscordSocketClient discordSocketClient, CommandService command, IServiceProvider serviceProvider)
        {
            _client = discordSocketClient;
            _commandService = command;
            _serviceProvider = serviceProvider;
        }

        public async Task RunBot()
        {
            await RegisterCommands();
            await _client.LoginAsync(TokenType.Bot, _botToken);
            await _client.StartAsync();
            await Task.Delay(-1);

        }

        public async Task RegisterCommands()
        {
            _client.MessageReceived += HandleCommand;
            await _commandService.AddModulesAsync(Assembly.GetAssembly(typeof(Commands)), _serviceProvider);
        }

        private async Task HandleCommand(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);
            if (message.Author.IsBot) return;

            int argPos = 0;
            if(message.HasStringPrefix("!", ref argPos))
            {
                var result = await _commandService.ExecuteAsync(context, argPos, _serviceProvider);
                if(!result.IsSuccess)
                {
                    var a = result.ErrorReason;
                    await context.Channel.SendMessageAsync($"Cosmin, you are so stupid, you have crushed the code due to \n{result.ErrorReason}");
                }
            }
        }       
    }
}
