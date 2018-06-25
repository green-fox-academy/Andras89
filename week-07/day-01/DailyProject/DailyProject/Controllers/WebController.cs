using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyProject.Controllers
{
    [Route("Web")]
    public class WebController : Controller
    {
        [Route("Greeting")]
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