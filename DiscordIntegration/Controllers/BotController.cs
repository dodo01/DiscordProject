using System;
using System.Threading.Tasks;
using DiscordIntegration.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiscordIntegration.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        private readonly IDiscordService _discordService;
        public BotController(IDiscordService discordService)
        {
            _discordService = discordService;
        }

        [HttpGet("[action]")]
        public async Task SendMessage()
        {
            await _discordService.SendMessage();
        }
    }
}
