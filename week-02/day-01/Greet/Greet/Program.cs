using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
            string al = "Greenfox";
            greet(al);
            Console.ReadLine();
        }

        public static void greet(string name)
        {
            Console.WriteLine("Greetings dear, {0}", name);
        }
    }
}