using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyProjectApiReboot.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyProjectApiReboot.Controllers
{
    [Produces("application/json")]
    [Route("Web/Greeting")]
    public class WebController : Controller
    {
        [HttpGet]
        public IActionResult Greeting()
        {
            Greeting greet = new Greeting()
            {
                Content = "Andrew"
            };

            return View(greet);
        }
    }
}