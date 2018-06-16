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

            FlipListCountPrinter();

            NamesStartingWithSPrinter();

            GetSquares(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            ListZipper(new List<int> { 1, 3, 5 }, new List<int> { 2, 4, 6 });

            ListAggregate(new List<int> { 1, 3, 5 });

            Console.ReadLine();
        }

        private static void ListAggregate(List<int> list)
        {
            Console.WriteLine(list.Aggregate((a, b) => a + b));
        }

        private static void ListZipper(List<int> listOne, List<int> listTwo)
        {
            IEnumerable<int> zipListSum = listOne.Zip(listTwo, (x, y) => x + y);

            foreach (var item in zipListSum)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private static void GetSquares(List<int> list)
        {
            IEnumerable<int> squares = list.Select(x => x * x);

            foreach (var item in squares)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private static void NamesStartingWithSPrinter()
        {
            List<string> allTheNames = new List<string> { "Sally", "Doug", "Sarah", "Allan", "Sigourney", "Sasha", "Jeremy" };

            IEnumerable<string> startWithSNames = allTheNames.Where(x => x.StartsWith('S')).Select(x => x.Replace('S', 'F'));

            foreach (var item in startWithSNames)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private static void FlipListCountPrinter()
        {
            List<int> flipList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                flipList.Add(rnd.Next(1, 3));
            }

            Console.WriteLine($"Heads: {flipList.Where(x => (x == 1)).ToList().Count}");
            Console.WriteLine($"Tails: {flipList.Where(x => (x == 2)).ToList().Count}");

            Console.WriteLine();
        }

        private static void SearchInBetweenNumbers(List<int> list)
        {
            IEnumerable<int> queryBetweenNums = from num in list
                                                where num > 4 && num <= 11
                                                select num;

            IEnumerable<int> lambdaBetweenNums = list.Where(x => (x > 4 && x <= 11)).ToList();

            List<int> tempQuery = queryBetweenNums.ToList();
            List<int> tempLambda = (List<int>)lambdaBetweenNums;

            for (int i = 0, j = 0; i < tempQuery.Count || j < tempLambda.Count; i++, j++)
            {
                Console.Write($"{tempQuery[i]} {tempLambda[i]}\t");
            }

            Console.WriteLine();
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
