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
            Sponsor Jane = new Sponsor();

            Console.WriteLine(Jane.Introduce());

            Jane.Hire();

            Console.WriteLine(Jane.Introduce());

            Console.ReadLine();
        }
    }
}
