using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    class Program
    {
        static void Main(string[] args)
        {
            PirateShip theBlackPearl = new PirateShip();
            PirateShip queenAnnesRevenge = new PirateShip();

            theBlackPearl.FillShip();
            queenAnnesRevenge.FillShip();

            Console.WriteLine(theBlackPearl.ShipStatus());
            Console.WriteLine(queenAnnesRevenge.ShipStatus());

            Console.WriteLine($"Does the Black Pearl win: " +
                              $"{theBlackPearl.Battle(queenAnnesRevenge)} \n");

            Console.WriteLine(theBlackPearl.ShipStatus());
            Console.WriteLine(queenAnnesRevenge.ShipStatus());



            Console.ReadLine();
        }
    }
}
