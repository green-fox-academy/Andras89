using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> listOfFoxes = new List<Fox>
            {
                new Fox("Pix", "pallida", "green"),
                new Fox("Vuk", "vipes", "red"),
                new Fox("Cheesus", "fulvipes", "ocelot"),
                new Fox("Heki", "macrotis", "pebble"),
                new Fox("Vox", "pallida", "green"),
            };

            var lambdaResult = listOfFoxes.Where(x => x.Type == "pallida" && x.Color == "green")
                                          .Select(x => x.Name);

            Console.Write(string.Join(", ", lambdaResult) + '\n');

            var queryResult = from fox in listOfFoxes
                              where fox.Type == "pallida" && fox.Color == "green"
                              select fox.Name;

            Console.Write(string.Join(", ", queryResult));

            Console.ReadLine();
        }
    }
}
