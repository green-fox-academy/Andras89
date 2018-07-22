using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyProject.Controllers
{
    [Route("Web")]
    [Route("")]
    public class WebController : Controller
    {
        [Route("Greeting")]
        [Route("")]
        public IActionResult Greeting()
        {
            Greeting greet = new Greeting()
            {
                Content = "Andrew"
            };

            return View(greet);
        }

        [Route("MultiGreeting/{name}")]
        public IActionResult MultiGreeting(string name)
        {
            MultiGreeting mGreeting = new MultiGreeting()
            {
                Name = name
            };

            return View(mGreeting);
        }
    }
}