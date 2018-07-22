using RedditREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditREST.Services
{
    public interface IService
    {
        List<Post> GetPosts();
        void AddPost(Post post);
        void UpVotePostById(int id);
        void DownVotePostById(int id);
        void DeletePost(int id);
        void EditPost(int id, Post post);
    }
}
