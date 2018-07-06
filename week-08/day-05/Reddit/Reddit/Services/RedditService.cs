using Reddit.Models;
using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class RedditService : IService
    {
        private PostRepository postRepo;

        public RedditService(PostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        public void AddVote(int id)
        {
            Post updatable = postRepo.Read().FirstOrDefault(x => x.Id == id);
            postRepo.Update(updatable);
        }

        public List<Post> GetAllPosts()
        {
            return postRepo.Read();
        }
    }
}
