using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;

namespace ToDoAppX.Repositories
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }
    }
}
