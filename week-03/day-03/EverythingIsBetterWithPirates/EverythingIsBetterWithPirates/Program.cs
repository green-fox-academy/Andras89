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
            Armada firstFleet = new Armada();
            Armada secondFleet = new Armada();

            firstFleet.Battle(secondFleet);

            Console.WriteLine(firstFleet.ArmadaStatus());
            Console.WriteLine(secondFleet.ArmadaStatus());

            Console.ReadLine();
        }
    }
}
