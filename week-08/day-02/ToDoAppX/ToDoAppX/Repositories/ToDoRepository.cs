using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoAppX.Models;

namespace ToDoAppX.Repositories
{
    public class ToDoRepository : IGeneralRepository<ToDo>
    {
        private ToDoDbContext todoDbContext;

        public ToDoRepository(ToDoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public void Create(ToDo element)
        {
            todoDbContext.Todos.Add(element);
            todoDbContext.SaveChanges();
        }

        public void Delete(ToDo element)
        {   
            todoDbContext.Todos.Remove(element);
            todoDbContext.SaveChanges();
        }

        public void Edit(ToDo element)
        {
            todoDbContext.Todos.Update(element);
            todoDbContext.SaveChanges();
        }

        public ToDo GetRecordById(long id)
        {
            return todoDbContext.Todos.ToList().FirstOrDefault(x => x.Id == id);
        }

        public List<ToDo> Read()
        {
            var output = todoDbContext.Todos.Include(a => a.Assignee);
            return output.ToList();
        }
    }
}
