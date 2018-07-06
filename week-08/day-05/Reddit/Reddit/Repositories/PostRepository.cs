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
            
        }

        public void Delete(Post element)
        {
            throw new NotImplementedException();
        }

        public List<Post> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Post element)
        {
            throw new NotImplementedException();
        }
    }
}
