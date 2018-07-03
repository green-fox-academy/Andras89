using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;

namespace ToDoAppX.Repositories
{
    public interface ICRUD
    {
        void Create(ToDo todo);
        List<ToDo> Read();
        void Delete(int id);
    }
}
