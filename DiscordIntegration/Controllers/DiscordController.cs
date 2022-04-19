using System;
using System.Threading.Tasks;
using DiscordIntegration.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiscordIntegration.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscordController : ControllerBase
    {
        private readonly IDiscordService _discordService;
        public DiscordController(IDiscordService discordService)
        {
            _discordService = discordService;
        }

        [HttpGet("[action]")]
        public async Task SendBotMessage()
        {
            await _discordService.SendBotMessage();
        }
    }
}
