using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogOne = new BlogPost("John Doe", "Lorem Ipsum",
                                            "Lorem ipsum dolor sit amet", "2000.05.04.");

            BlogPost blogTwo = new BlogPost("Tim Urban", "Wait but why",
                                            "A popular long-form, stick-figure-" +
                                            "illustrated blog about almost everything", "2010.10.10.");

            BlogPost blogThree = new BlogPost("William Turton", "Daniel Hanley One Engineer Is Trying to Get IBM to Reckon With Trump",
                                            "a cybersecurity engineer at IBM, " +
                                            " doesn’t want to be the center of attention. When I asked to take" +
                                            " his picture outside one of IBM’s New York City offices, he told me " +
                                            "that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine($"{blogThree.AuthorName} \n {blogThree.Title} \n {blogThree.PublicationDate} \n {blogThree.Text}");
            Console.ReadLine();
        }
    }
}
