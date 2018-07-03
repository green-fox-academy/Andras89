using Microsoft.EntityFrameworkCore;

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
