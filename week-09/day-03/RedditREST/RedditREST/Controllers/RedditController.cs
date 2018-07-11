using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditREST.Models;
using RedditREST.Services;

namespace RedditREST.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class RedditController : Controller
    {
        private IService database;

        public RedditController(IService database)
        {
            this.database = database;
        }

        [HttpGet("/posts")]
        [Route("")]
        public IActionResult ListPosts()
        {
            return Json(new { posts = database.GetPosts() });
        }

        [HttpPost("/posts")]
        public IActionResult GetPost([FromBody] Post post)
        {
            database.AddPost(post);

            return RedirectToAction("ListPosts");
        }

        [HttpPut("/posts/{id}/upvote")]
        public IActionResult UpVote(int id)
        {
            database.UpVotePostById(id);

            return RedirectToAction("ListPosts);
        }
    }
}