using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiscordIntegration.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberOfTheMonthController : ControllerBase
    {
        // GET: api/values
        [HttpGet("[action")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
    }
}
