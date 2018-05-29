using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jane = new Mentor();

            Console.WriteLine(Jane.Introduce());

            Console.ReadLine();
        }
    }
}
