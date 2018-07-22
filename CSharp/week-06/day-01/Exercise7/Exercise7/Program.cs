using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.Write(string.Join(", ", cities.Where(x => x.StartsWith('A') && x.EndsWith('I'))) + '\n');

            var queryResult = from city in cities
                              where city[0] == 'A' && city[city.Length - 1] == 'I'
                              select city;

            Console.WriteLine(string.Join(", ", queryResult));

            Console.ReadLine();
        }
    }
}
