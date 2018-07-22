using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyProject.Controllers
{
    [Route("Api")]
    public class RESTController : Controller
    {       
        [Route("Greeting/{name}")]
        public IActionResult Greeting([FromRoute] string name)
        {
            Greeting greet = new Greeting()
            {                
                Content = "Hello, " + name
            };

            return new JsonResult(greet);
        }
    }
}