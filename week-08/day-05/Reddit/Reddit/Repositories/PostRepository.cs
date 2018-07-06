using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class PostRepository : IGenericRepository<Post>
    {
        RedditDbContext dbContext;

        public PostRepository(RedditDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Post element)
        {
            dbContext.Posts.Add(element);
            dbContext.SaveChanges();
        }

        public void Delete(Post element)
        {
            dbContext.Posts.Remove(element);
            dbContext.SaveChanges();
        }

        public List<Post> Read()
        {
            return dbContext.Posts.ToList();
        }

        public void Update(Post element)
        {
            dbContext.Posts.Update(element);
            dbContext.SaveChanges();
        }
    }
}
