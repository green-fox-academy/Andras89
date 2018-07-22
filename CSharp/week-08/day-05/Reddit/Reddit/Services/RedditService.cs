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

        public void AddPost(Post post)
        {
            post.CreatedAt = DateTime.Now.ToString("yyyy/MM/dd H:mm");
            postRepo.Add(post);
        }

        public void AddVote(int id)
        {
            Post updatable = postRepo.Read().FirstOrDefault(x => x.Id == id);
            updatable.Vote++;

            postRepo.Update(updatable);
        }

        public List<Post> GetAllPosts()
        {
            return postRepo.Read();
        }

        public void SubstractVote(int id)
        {
            Post updatable = postRepo.Read().FirstOrDefault(x => x.Id == id);
            updatable.Vote--;

            postRepo.Update(updatable);
        }
    }
}
