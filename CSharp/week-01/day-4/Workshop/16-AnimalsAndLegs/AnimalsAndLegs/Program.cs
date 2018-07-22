using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            int chickenNumber = int.Parse(Console.ReadLine());
            int pigNumber = int.Parse(Console.ReadLine());

            int chickenLegCount = 2;
            int pigLegCount = 4;

            int animalLegsNumber = chickenNumber * chickenLegCount + pigNumber * pigLegCount;

            Console.WriteLine(animalLegsNumber);

            Console.ReadLine();
        }
    }
}