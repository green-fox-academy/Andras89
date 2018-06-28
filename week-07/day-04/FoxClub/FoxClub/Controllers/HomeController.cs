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
    public class HomeController : Controller
    {
        IFox foxClub;

        public HomeController(IFox foxClub)
        {
            this.foxClub = foxClub;
        }

        [HttpGet("/Index")]
        public IActionResult Index()
        {
            return View("Index", foxClub.GetName());
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
            foxClub.SetName(name);
            return RedirectToAction("Index");
        }
    }
}
