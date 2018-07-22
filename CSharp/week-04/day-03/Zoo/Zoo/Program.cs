using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantChild());

            Console.ReadLine();
        }
    }
}
