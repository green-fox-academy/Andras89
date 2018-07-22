using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            Console.WriteLine(n.Where(x => x % 2 == 1).Average());

            var result = (from num in n
                          where num % 2 == 1
                          select num).Average();

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
