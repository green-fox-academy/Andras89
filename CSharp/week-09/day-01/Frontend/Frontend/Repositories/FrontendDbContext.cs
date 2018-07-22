using Frontend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repository
{
    public class FrontendDbContext : DbContext
    {
        public DbSet<Logger> LoggerDb { get; set; }

        public FrontendDbContext(DbContextOptions<FrontendDbContext> options) : base(options)
        {

        }
    }
}
