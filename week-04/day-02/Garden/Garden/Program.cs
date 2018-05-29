using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();

            Console.WriteLine(garden.Info());
            Console.WriteLine();
            Console.WriteLine(garden.Water(40));
            Console.WriteLine();
            Console.WriteLine(garden.Water(70));

            Console.ReadLine();
        }
    }
}
