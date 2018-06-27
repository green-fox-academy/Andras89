using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class ToDoService : IToDo
    {
        private List<ToDo> database = new List<ToDo>();

        public List<ToDo> GetToDoDatabase()
        {
            return database;
        }

        public void SetToDo(ToDo input)
        {
            database.Add(input);
        }
    }
}
