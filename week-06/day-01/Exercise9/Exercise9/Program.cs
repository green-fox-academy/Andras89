using System;
using System.Linq;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[] { 'Y', 'o', 'l', 'o' };

            var lambdaResult = string.Join("", input.Select(x => x.ToString()));

            Console.WriteLine(lambdaResult);

            var queryResult = from character in input
                              select character.ToString();

            Console.WriteLine(string.Join("", queryResult));

            Console.ReadLine();
        }
    }
}
