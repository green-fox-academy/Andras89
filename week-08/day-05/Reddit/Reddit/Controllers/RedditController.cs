using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Services;

namespace Reddit.Controllers
{
    [Route("")]
    public class RedditController : Controller
    {
        private IService database;

        public RedditController(IService database)
        {
            this.database = database;
        }

        [HttpGet("")]
        [Route("list")]
        public IActionResult List()
        {
            return View();
        }
    }
}