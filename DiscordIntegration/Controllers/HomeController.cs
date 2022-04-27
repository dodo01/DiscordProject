using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiscordIntegration.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Error()
        {
            return null;//View(new ErrorViewModel { RequestId = Activity.Current?.Id });
        }

    }
}
