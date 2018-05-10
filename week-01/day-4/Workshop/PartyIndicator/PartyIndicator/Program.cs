using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            int girlCount;
            int guyCount;

            girlCount = int.Parse(Console.ReadLine());
            guyCount = int.Parse(Console.ReadLine());

            if (girlCount == guyCount && girlCount + guyCount > 20)
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (girlCount == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else if (girlCount + guyCount > 20 && girlCount / guyCount != 1)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (girlCount + guyCount < 20)
            {
                Console.WriteLine("Average party...");
            }
            else
            {
                Console.WriteLine("Whaaaaat?");
            }

            Console.ReadLine();


        }
    }
}