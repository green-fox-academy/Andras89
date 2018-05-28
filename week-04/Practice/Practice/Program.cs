using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    class Program
    {
        public class Animal
        {
            public string Name;
            public int Age;
            public double Hapiness;

            public void PrintValues()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Hapiness: " + Hapiness);
            }
        }

        class Dog : Animal
        {
            public int SpotCount;

            public void Bark()
            {
                Console.WriteLine("WUF!");
                base.Hapiness += 0.1;
            }
        }

        class Cat : Animal
        {
            public double Cuteness;

            public void Meow()
            {
                Console.WriteLine("Meow!");
            }
        }

        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.Name = "Spotty";

            spotty.Age = 4;
            spotty.Hapiness = 0.89;
            spotty.SpotCount = 34;

            spotty.PrintValues();
            spotty.Bark();

            Console.WriteLine("New happiness: " + spotty.Hapiness);

            Console.WriteLine();

            Cat heisenberg = new Cat();
            heisenberg.Name = "Heisenberg";
            heisenberg.Age = 6;
            heisenberg.Hapiness = 0.67;
            heisenberg.Cuteness = 0.45;

            heisenberg.PrintValues();
            heisenberg.Meow();

            Console.ReadLine();
        }
    }
}
