using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoAppX.Models;
using ToDoAppX.Repositories;
using ToDoAppX.Services;

namespace ToDoAppX.Controllers
{
    [Route("")]
    [Route("todo")]
    public class ToDoController : Controller
    {
        IService database;

        public ToDoController(IService database)
        {
            this.database = database;
        }

        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return View(database.ReadToDos());
        }

        [HttpPost("list")]
        public IActionResult Search(string input)
        {
            return View("~/Views/ToDo/List.cshtml", database.SearchToDos(input));
        }

        [HttpGet("listass")]
        public IActionResult ListAssignees()
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
            database.CreateToDo(todo);
            return RedirectToAction("list");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult RemoveToDoWithIdFromDatabase(int id)
        {
            database.DeleteToDoByID(id);

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
            database.EditToDo(todo);
            return RedirectToAction("list");
        }
    }
}