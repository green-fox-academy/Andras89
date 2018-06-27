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
        private int id = 0;

        public List<ToDo> GetToDoDatabase()
        {
            return database;
        }

        public void RemoveToDo(int input)
        {
            List<ToDo> temp = database.Where(x => x.Id != input).ToList();
            database = temp;
        }

        public void SetId()
        {
            id++;
        }

        public void SetToDo(ToDo input)
        {
            SetId();
            input.Id = id;
            database.Add(input);
        }
    }
}
