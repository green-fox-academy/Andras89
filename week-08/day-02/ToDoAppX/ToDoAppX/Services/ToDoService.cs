using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;
using ToDoAppX.Repositories;

namespace ToDoAppX.Services
{
    public class ToDoService : IService
    {
        private ToDoRepository todoRepo;
        private AssigneeRepository assigneeRepo;

        public ToDoService(ToDoRepository todoRepo, AssigneeRepository assigneeRepo)
        {
            this.todoRepo = todoRepo;
            this.assigneeRepo = assigneeRepo;
        }

        public void CreateToDo(ToDo todo)
        {
            todoRepo.Create(todo);
        }

        public void DeleteToDoByID(int id)
        {
            var deletable = todoRepo.GetRecordById(id);
            todoRepo.Delete(deletable);
        }

        public void EditToDo(ToDo todo)
        {
            todoRepo.Edit(todo);
        }

        public ToDo GetTodoById(long id)
        {
            return todoRepo.GetRecordById(id);
        }

        public List<ToDo> ReadToDos()
        {
            return todoRepo.Read();
        }
    }
}
