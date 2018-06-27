using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public interface IToDo
    {
        void SetToDo(ToDo input);
        List<ToDo> GetToDoDatabase();
    }
}
