using RedditREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditREST.Services
{
    public class RedditService : IService
    {
        private PostRepository postRepo;

        public RedditService(PostRepository postRepo)
        {
            this.postRepo = postRepo;
        }
    }
}
