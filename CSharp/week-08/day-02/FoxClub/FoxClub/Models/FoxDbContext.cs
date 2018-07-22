using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxDbContext :DbContext
    {
        public DbSet<Fox> Foxes { get; set; }

        public FoxDbContext(DbContextOptions<FoxDbContext> options) : base(options)
        {
        }
    }
}
