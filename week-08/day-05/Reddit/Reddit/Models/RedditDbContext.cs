using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class RedditDbContext : DbContext
    {
        private DbSet<Post> Posts { get; set; }

        public RedditDbContext(DbContextOptions<RedditDbContext> options) : base(options)
        {

        }
    }
}
