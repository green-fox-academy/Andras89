using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write random string:");

            string input = Console.ReadLine();

            Dictionary<char, int> lambdaResult = input.Where(x => x != ' ')
                                                      .GroupBy(x => x)
                                                      .ToDictionary(x => x.Key, x => x.ToList().Count);

            foreach (KeyValuePair<char, int> item in lambdaResult)
            {
                Console.Write($"{item.Key}: {item.Value} , ");
            }

            Console.WriteLine();

            var queryResult = from character in input
                              where character != ' '
                              group character by character into grouping
                              select new
                              {
                                  HeadChar = grouping.Key,
                                  CharCounter = grouping.Count()
                              };

            foreach (var item in queryResult)
            {
                Console.Write($"{item.HeadChar}: {item.CharCounter} , ");
            }

            Console.ReadLine();
        }
    }
}
