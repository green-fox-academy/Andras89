using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoAppX.Repositories;

namespace ToDoAppX.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        ICRUD database;

        public ToDoController(ICRUD database)
        {
            this.database = database;
        }

        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return Content("This is my first todo");
        }
    }
}