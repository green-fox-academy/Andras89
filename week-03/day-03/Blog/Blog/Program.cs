using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog blogList = new Blog();

            blogList = BlogInitializer(blogList);

            blogList.PrintOutBlog();

            Console.ReadLine();
        }

        private static Blog BlogInitializer(Blog blogList)
        {
            for (int i = 0; i < 10; i++)
            {
                blogList.Add(new BlogPost($"{i+1}. John Doe", "Disturbed", "Cool Band!", "2018.05.23."));
            }

            return blogList;
        }
    }
}
