using RedditREST.Models;
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

        public void AddPost(Post post)
        {
            post.Score = 0;
            post.Timestamp = (int)ConvertToUnixTimestamp(DateTime.Now);

            postRepo.Create(post);
        }

        private double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public List<Post> GetPosts()
        {
            return postRepo.Read();
        }
    }
}
