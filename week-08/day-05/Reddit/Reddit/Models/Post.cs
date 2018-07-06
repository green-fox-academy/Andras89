using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public int Vote { get; set; }
    }
}
