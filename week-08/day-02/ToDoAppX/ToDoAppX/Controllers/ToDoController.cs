using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoAppX.Models;
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
            return View(database.Read());
        }

        [HttpPost("list")]
        public IActionResult AddTodoToDatabase(ToDo todo)
        {
            database.Create(todo);
            return RedirectToAction("Index");
        }
    }
}