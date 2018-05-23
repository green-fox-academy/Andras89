using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal elephant = new Animal();

            for (int i = 0; i < 30; i++)
            {
                elephant.Eat();
            }

            Console.WriteLine(elephant.AnimalData()[0]);
            Console.ReadLine();
        }
    }
}
