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
    [Route("api")]
    public class RESTController : Controller
    {
        [HttpGet]
        [Route("Greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greet = new Greeting()
            {
                Content = "Ima greeting method in REST" + name
            };

            return new JsonResult(greet);
        }
    }
}