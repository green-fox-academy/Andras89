using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write(string.Join(", ", n.Where(x => Math.Pow(x, 2) > 20)) + '\n');

            IEnumerable<int> result = from num in n
                                      where Math.Pow(num, 2) > 20
                                      select num;

            Console.Write(string.Join(", ", result));

            Console.ReadLine();
        }
    }
}
