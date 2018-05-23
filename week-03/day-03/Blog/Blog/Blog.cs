using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Blog
    {
        List<BlogPost> BlogList = new List<BlogPost>();

        public void Add(BlogPost blogPost)
        {
            BlogList.Add(blogPost);
        }

        public void PrintOutBlog()
        {
            foreach (BlogPost item in BlogList)
            {
                Console.WriteLine($"{item.AuthorName}, {item.Title}, {item.Text}, {item.PublicationDate}");
            }
        }

        public void Update(int index, BlogPost blogPost)
        {
            BlogList[index] = blogPost;
        }

        public void Delete(int index)
        {
            BlogList.RemoveAt(index);
        }
    }
}
