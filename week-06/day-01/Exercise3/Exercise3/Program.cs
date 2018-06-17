using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            Console.Write(string.Join(", ", n.Where(x => x > 0).Select(x => Math.Pow(x, 2))));

            Console.WriteLine();

            var result = from num in n
                         where num > 0
                         select Math.Pow(num, 2);

            Console.Write(string.Join(", ", result));

            Console.ReadLine();
        }
    }
}
