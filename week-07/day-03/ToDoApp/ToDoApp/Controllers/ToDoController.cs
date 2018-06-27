using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
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
            return View(database.GetToDoDatabase());
        }

        [HttpPost("/")]
        public IActionResult AddToDo(ToDo todo)
        {
            database.SetToDo(todo);
            return RedirectToAction("Index");
        }

        [HttpPost("remove")]
        public IActionResult RemoveTodo(int input)
        {
            database.RemoveToDo(input);
            return RedirectToAction("Index");
        }

        [HttpPost("urgent")]
        public IActionResult MakeUrgent(int input)
        {
            database.SetUrgentToDo(input);
            return RedirectToAction("Index");
        }

        [HttpPost("writejson")]
        public IActionResult WriteToJson()
        {
            database.SaveToFile();
            return RedirectToAction("Index");
        }
    }
}