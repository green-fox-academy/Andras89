using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpieSet sharpieList = new SharpieSet();

            sharpieList.Add(new Sharpie("black", 100, 100));
            sharpieList.Add(new Sharpie("black", 100, 50));
            sharpieList.Add(new Sharpie("black", 100, 0));
            sharpieList.Add(new Sharpie("black", 100, 100));
            sharpieList.Add(new Sharpie("black", 100, 200));
            sharpieList.Add(new Sharpie("black", 100, 0));
            sharpieList.Add(new Sharpie("black", 100, 40));
            sharpieList.Add(new Sharpie("black", 100, 0));
            sharpieList.Add(new Sharpie("black", 100, 0));

            Console.WriteLine(sharpieList.CountUsable());
            sharpieList.Removetrash();

            sharpieList.PrintOut();

            Console.ReadLine();
        }
    }
}
