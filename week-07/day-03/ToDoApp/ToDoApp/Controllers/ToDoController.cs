using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    [Route("/")]
    public class ToDoController : Controller
    {
        IToDo database;

        public ToDoController(IToDo database)
        {
            this.database = database;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}