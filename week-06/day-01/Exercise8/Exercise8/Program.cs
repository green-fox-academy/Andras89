using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string input:");

            string input = Console.ReadLine();

            Console.Write(string.Join(", ", input.Where(x => x.ToString().ToUpper() == x.ToString()).Except(new char[] { ' ', '!', '%' })) + '\n');

            var queryResult = (from character in input
                              where character.ToString().Equals(character.ToString().ToUpper())
                              select character).Except(new char[] { ' ', '!', '%' });

            Console.Write(string.Join(", ", queryResult));

            Console.ReadLine();
        }
    }
}
