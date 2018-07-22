using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    [Route("/")]
    public class GreetController : Controller
    {
        private IGreet greet;

        public GreetController(IGreet greet)
        {
            this.greet = greet; 
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult GetName(string name)
        {
            greet.SetName(name);
            return RedirectToAction("greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View("greet", greet.GetName());
        }
    }
}