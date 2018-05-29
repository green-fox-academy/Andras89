using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            F16 plane = new F16();

            plane.ReFill(500);

            Console.WriteLine(plane.GetStatus());
            Console.WriteLine(plane.isPriority());

            Console.ReadLine();
        }
    }
}
