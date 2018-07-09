using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Frontend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class HomeController : Controller
    {
        private LoggerRepository database;

        public HomeController(LoggerRepository database)
        {
            this.database = database;
        }

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
                database.Create(new Logger { CreatedAt = DateTime.Now,
                                             Endpoint = "doubling",
                                             Data = $"input={input}"});

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
                database.Create(new Logger
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = "greeter",
                    Data = $"name={name}, title={title}"
                });

                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            database.Create(new Logger
            {
                CreatedAt = DateTime.Now,
                Endpoint = "appenda",
                Data = $"appendable={appendable}"
            });

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
                database.Create(new Logger
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = "dountil",
                    Data = $"sum={until.until}"
                });

                output = 0;
                for (int i = 1; i <= until.until; i++)
                {
                    output += i;
                }
                return Json(new { until = until.until,
                    result = output });
            } else if (what == "factor")
            {
                database.Create(new Logger
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = "dountil",
                    Data = $"factor={until.until}"
                });

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
            int output;
            List<int> outputNumbers;

            if(json.what is "sum")
            {
                database.Create(new Logger
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = "arrays",
                    Data = $"sum={json.numbers}"
                });

                output = 0;
                foreach (int item in json.numbers)
                {
                    output += item;
                }

                return Json(new { result = output });
            }

            if(json.what is "multiply")
            {
                database.Create(new Logger
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = "arrays",
                    Data = $"multiply={json.numbers}"
                });

                output = 1;
                foreach (int item in json.numbers)
                {
                    output *= item;
                }

                return Json(new { result = output });
            }

            if(json.what is "double")
            {
                database.Create(new Logger
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = "arrays",
                    Data = $"double={json.numbers}"
                });

                outputNumbers = new List<int>();
                foreach (int item in json.numbers)
                {
                    outputNumbers.Add(item * 2);
                }

                return Json(new { result = outputNumbers.ToArray() });
            }

            return Json(new { error = "Please provide what to do with the numbers!" });
        }

        [HttpGet("log")]
        public IActionResult Logger()
        {
            return Json(new { entries = database.Read(),
                              entry_count = database.Read().Count});
        }
    }
}