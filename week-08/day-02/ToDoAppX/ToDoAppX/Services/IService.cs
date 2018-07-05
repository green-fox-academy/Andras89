using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;

namespace ToDoAppX.Services
{
    public interface IService
    {
        List<ToDo> ReadToDos();
        void CreateToDo(ToDo todo);
        void DeleteToDoByID(int id);
        ToDo GetTodoById(long id);
        void EditToDo(ToDo todo);
    }
}
