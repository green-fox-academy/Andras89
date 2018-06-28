using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.Services;

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        IFox foxClub;

        public HomeController(IFox foxClub)
        {
            this.foxClub = foxClub;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            return View(foxClub);
        }

        [Route("")]
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult GetFoxName(string name)
        {
            foxClub.CheckFox(name);
            return RedirectToAction("Index");
        }
    }
}
