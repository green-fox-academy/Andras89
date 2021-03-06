﻿using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public interface IService
    {
        List<Post> GetAllPosts();
        void AddVote(int id);
        void SubstractVote(int id);
        void AddPost(Post post);
    }
}
