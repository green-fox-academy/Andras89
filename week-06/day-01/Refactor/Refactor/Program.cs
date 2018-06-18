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

            IEnumerable<int> lambdaResultEven = array.Where(x => x % 2 == 0);


            IEnumerable<int> queryResultEven = from number in array
                                           where number % 2 == 0
                                           select number;

            lambdaResultEven.ToList().ForEach(xout => Console.Write($"{xout}, "));
            Console.WriteLine();
            queryResultEven.ToList().ForEach(xout => Console.Write($"{xout}, "));
            Console.WriteLine();

            double lambdaResultAverage = array.Where(x => x % 2 == 1).Average();

            double queryResultAverage = (from number in array
                                         where number % 2 == 1
                                         select number).Average();

            Console.WriteLine(lambdaResultAverage);
            Console.WriteLine(queryResultAverage);

            IEnumerable<double> lambdaResultPosSquare = array.Where(x => x > 0).Select(x => Math.Pow(x, 2));

            IEnumerable<double> queryResultPosSquare = from number in array
                                                       where number > 0
                                                       select Math.Pow(number, 2);

            lambdaResultPosSquare.ToList().ForEach(xout => Console.Write($"{xout}, "));
            Console.WriteLine();
            queryResultPosSquare.ToList().ForEach(xout => Console.Write($"{xout}, "));



            Console.ReadLine();
        }
    }
}
