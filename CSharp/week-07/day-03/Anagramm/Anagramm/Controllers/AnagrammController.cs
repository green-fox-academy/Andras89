using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Controllers
{
    [Route("/")]
    public class AnagrammController : Controller
    {
        IAnagramm anagramm;

        public AnagrammController(IAnagramm anagramm)
        {
            this.anagramm = anagramm;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult AnagrammChecker(string input)
        {
            anagramm.CheckAnagramm(input);
            return RedirectToAction("ShowIsAnagramm");
        }

        [HttpGet("anagramm")]
        public IActionResult ShowIsAnagramm()
        {
            return View("ShowIsAnagramm", anagramm.GetAnagramm());
        }
    }
}