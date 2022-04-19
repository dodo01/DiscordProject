using System;
using Microsoft.AspNetCore.Mvc;

namespace DiscordIntegration.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscordController : ControllerBase
    {

        [HttpGet("[action]")]
        public string TestApi()
        {
            return "Hello world!";
        }
    }
}
