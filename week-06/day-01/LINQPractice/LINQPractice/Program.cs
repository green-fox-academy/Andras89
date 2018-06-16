using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEvenNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });

            SearchInBetweenNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 });

            Console.ReadLine();
        }

        private static void SearchInBetweenNumbers(List<int> list)
        {
            
        }

        private static void SearchEvenNumbers(List<int> list)
        {
            IEnumerable<int> evenNums = from num in list
                                        where num % 2 == 0
                                        select num;

            IEnumerable<int> evenNumsMethod = list.Where(x => (x % 2 == 0)).ToList();

            foreach (var item in evenNums)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            foreach (var item in evenNumsMethod)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
