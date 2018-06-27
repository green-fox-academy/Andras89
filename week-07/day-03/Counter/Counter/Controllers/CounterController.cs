using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Services;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    [Route("/")]
    public class CounterController : Controller
    {
        private ICounter counter;

        public CounterController(ICounter counter)
        {
            this.counter = counter;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(counter.GetNumber());
        }

        [HttpPost("/")]
        public IActionResult Increment()
        {
            counter.Increment();
            return RedirectToAction("Index");
        }
    }
}