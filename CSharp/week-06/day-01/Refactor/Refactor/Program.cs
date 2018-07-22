using System;
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
            Console.WriteLine();

            string input = Console.ReadLine();

            var lambdaResultFreqChar = input.Where(x => x != ' ').GroupBy(g => g);

            var queryResultFreqChar = from character in input
                                      where character != ' '
                                      group character by character into characterGroup
                                      select characterGroup;

            lambdaResultFreqChar.ToList().ForEach(x => Console.Write($"{x.Key}: {x.ToList().Count()} , "));
            Console.WriteLine();
            queryResultFreqChar.ToList().ForEach(g => Console.Write($"{g.Key}: {g.ToList().Count()} , "));
            Console.WriteLine();

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> lambdaResultStartAEndI = cities.Where(x => x.StartsWith('A') && x.EndsWith('I'));

            IEnumerable<string> queryResultStartAEndI = from city in cities
                                                        where city[0].Equals('A') && city[city.Length - 1].Equals('I')
                                                        select city;

            lambdaResultStartAEndI.ToList().ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();
            queryResultStartAEndI.ToList().ForEach(x => Console.WriteLine($"{x}, "));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
