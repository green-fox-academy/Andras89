using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoAppX.Models;

namespace ToDoAppX.Repositories
{
    public class ToDoRepository : ICRUD
    {
        private ToDoContext todos;

        public ToDoRepository(ToDoContext todos)
        {
            this.todos = todos;
        }

        public void Create(ToDo todo)
        {
            todos.Add(todo);
            todos.SaveChanges();
        }

        public List<ToDo> Read()
        {
            return todos.Todos.ToList();
        }
    }
}
