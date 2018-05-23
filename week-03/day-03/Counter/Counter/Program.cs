using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter sum = new Counter();

            sum.Add(345);
            Console.WriteLine(sum.Get());

            Console.ReadLine();
        }
    }
}
