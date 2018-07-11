using RedditREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditREST.Repositories
{
    public class PostRepository : IGenericRepository<Post>
    {
        private RedditRestDbContext redditRestDb;

        public PostRepository(RedditRestDbContext redditRestDb)
        {
            this.redditRestDb = redditRestDb;
        }

        public void Create(Post element)
        {
            redditRestDb.Posts.Add(element);
            redditRestDb.SaveChanges();
        }

        public void Delete(Post element)
        {
            redditRestDb.Posts.Remove(element);
            redditRestDb.SaveChanges();
        }

        public List<Post> Read()
        {
            return redditRestDb.Posts.ToList();
        }

        public void Update(Post element)
        {
            redditRestDb.Posts.Update(element);
            redditRestDb.SaveChanges();
        }
    }
}
