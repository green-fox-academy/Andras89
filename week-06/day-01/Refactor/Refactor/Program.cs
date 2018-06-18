using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> lambdaResult = array.Where(x => x % 2 == 0);


            IEnumerable<int> queryResult = from number in array
                                           where number % 2 == 0
                                           select number;

            lambdaResult.ToList().ForEach(xout => Console.Write($"{xout}, "));
            Console.WriteLine();
            queryResult.ToList().ForEach(xout => Console.Write($"{xout}, "));

            Console.ReadLine();
        }
    }
}
