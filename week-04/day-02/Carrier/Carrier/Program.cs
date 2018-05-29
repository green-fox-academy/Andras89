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
            plane.ReFill(100);
            Console.WriteLine(plane.GetStatus());
            Console.WriteLine();

            Carrier ussBenedict = new Carrier(5000, 2300);

            ussBenedict.Add(new F35());
            ussBenedict.Add(new F35());
            ussBenedict.Add(new F35());

            ussBenedict.Add(new F16());
            ussBenedict.Add(new F16());

            Console.WriteLine(ussBenedict.GetStatus());
            Console.WriteLine();

            Console.WriteLine(ussBenedict.GetStatus());

            Console.ReadLine();
        }
    }
}
