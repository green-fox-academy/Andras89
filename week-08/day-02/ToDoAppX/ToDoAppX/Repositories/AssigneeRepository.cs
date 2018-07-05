using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoAppX.Repositories
{
    public class AssigneeRepository : IGeneralRepository<Assignee>
    {
        ToDoDbContext toDoDbContext;

        public AssigneeRepository(ToDoDbContext toDoDbContext)
        {
            this.toDoDbContext = toDoDbContext;
        }

        public void Create(Assignee element)
        {
            toDoDbContext.Assignees.Add(element);
            toDoDbContext.SaveChanges();
        }

        public void Delete(Assignee element)
        {
            toDoDbContext.Assignees.Add(element);
            toDoDbContext.SaveChanges();
        }

        public void Edit(Assignee element)
        {
            toDoDbContext.Assignees.Update(element);
            toDoDbContext.SaveChanges();
        }

        public Assignee GetRecordById(long id)
        {
            return toDoDbContext.Assignees.ToList().FirstOrDefault(x => x.Id == id);
        }

        public List<Assignee> Read()
        {
            var output = toDoDbContext.Assignees.Include(ass => ass.ToDos);
            return output.ToList();
        }
    }
}
