using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            string name;
            Console.WriteLine("Hello, What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0}",name);

            Console.ReadLine();

        }
    }
}