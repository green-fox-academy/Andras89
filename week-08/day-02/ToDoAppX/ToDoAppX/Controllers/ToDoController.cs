using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoAppX.Models;
using ToDoAppX.Repositories;

namespace ToDoAppX.Controllers
{
    [Route("")]
    [Route("todo")]
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
            return View(database);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddTodoToDatabase(ToDo todo)
        {
            database.Create(todo);
            return RedirectToAction("list");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult RemoveToDoWithIdFromDatabase(int id)
        {
            database.Delete(id);

            return RedirectToAction("list");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Edit(long id)
        {
            return View("Edit", database.GetTodoById(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult EditTheDatabase(ToDo todo)
        {
            database.Edit(todo);
            return RedirectToAction("list");
        }
    }
}