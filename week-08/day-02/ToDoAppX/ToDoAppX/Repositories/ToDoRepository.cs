using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppX.Repositories
{
    public class ToDoRepository : ICRUD
    {
        ToDoContext todos;

        public ToDoRepository(DbContextOptions<ToDoContext> options)
        {
            todos = new ToDoContext(options);
        }
    }
}
