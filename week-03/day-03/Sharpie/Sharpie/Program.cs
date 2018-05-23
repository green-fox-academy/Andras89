using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie numberOne = new Sharpie("Blue", 200);

            for (int i = 0; i < 30; i++)
            {
                numberOne.Use();
            }

            Console.WriteLine(numberOne.NumberOfUsesLeft());
            Console.ReadLine();
        }
    }
}
