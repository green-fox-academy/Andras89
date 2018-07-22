using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;

namespace ToDoAppX.Repositories
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {
        }
    }
}
