using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoAppX.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return Content("This is my first todo");
        }
    }
}