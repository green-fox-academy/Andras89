using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery] int? input)
        {
            if (input is null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new {
                    received = input,
                    result = input * 2 });
            }
        }

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery] string name, [FromQuery] string title)
        {
            if (name is null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title is null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]Until until)
        {
            int output;

            if (until.until is null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (what == "sum")
            {
                output = 0;
                for (int i = 1; i <= until.until; i++)
                {
                    output += i;
                }
                return Json(new { until = until.until,
                    result = output });
            } else if (what == "factor")
            {
                output = 1;
                for (int i = 1; i <= until.until; i++)
                {
                    output *= i;
                }

                return Json(new { until = until.until,
                    result = output });
            }

            return Json(new { error = "Please provide a working function!" });
        }

        [HttpPost("arrays")]
        public IActionResult Arrays(string what, [FromBody]ArrayJsonObject json)
        {

        }
    }
}