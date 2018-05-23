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
            theBlackPearl.ShipStatus();

            queenAnnesRevenge.FillShip();
            queenAnnesRevenge.ShipStatus();

            Console.WriteLine(theBlackPearl.Battle(queenAnnesRevenge));

            theBlackPearl.ShipStatus();
            queenAnnesRevenge.ShipStatus();



            Console.ReadLine();
        }
    }
}
