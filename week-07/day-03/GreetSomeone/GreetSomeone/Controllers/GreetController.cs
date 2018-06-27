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
        IGreet greet;

        public GreetController(IGreet greet)
        {
            this.greet = greet; 
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult GetName()
        {
            return RedirectToAction("Greet");
        }
    }
}