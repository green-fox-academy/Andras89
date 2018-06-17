using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Dictionary<int, int> lambdaResult = n.OrderBy(x => x)
                                                 .GroupBy(x => x)
                                                 .ToDictionary(x => x.Key, x => x.ToList().Count);

            foreach (KeyValuePair<int, int> item in lambdaResult)
            {
                Console.Write($"{item.Key}: {item.Value}  ");
            }

            Console.WriteLine();

            var queryResult = from num in n
                              orderby num
                              group num by num into sortedGroup
                              select sortedGroup;

            foreach (var item in queryResult)
            {
                Console.Write($"{item.Key}: {item.Count()}  ");
            }

            Console.ReadLine();
        }
    }
}
