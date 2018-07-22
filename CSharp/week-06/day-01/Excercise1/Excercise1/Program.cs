using System;
using System.Linq;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            Console.Write(string.Join(", ", n.Where(x => x % 2 == 0)));

            Console.WriteLine();

            var result = from num in n
                         where num % 2 == 0
                         select num;

            Console.Write(string.Join(", ", result));

            Console.ReadLine();
        }
    }
}
