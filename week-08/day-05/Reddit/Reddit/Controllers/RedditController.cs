using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Reddit.Controllers
{
    [Route("")]
    public class RedditController : Controller
    {
        [HttpGet("")]
        [Route("list")]
        public IActionResult List()
        {
            return View();
        }
    }
}