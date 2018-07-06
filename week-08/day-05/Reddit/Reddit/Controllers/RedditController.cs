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
            return View(database.GetAllPosts());
        }

        [HttpGet("/{id}/add")]
        public IActionResult AddVote(int id)
        {
            database.AddVote(id);
            return RedirectToAction("list");
        }

        [HttpGet("/{id}/substract")]
        public IActionResult SubstractVote(int id)
        {
            database.SubstractVote(id);
            return RedirectToAction("list");
        }

        [HttpGet("addpost")]
        public IActionResult AddPost()
        {
            return View();
        }
    }
}