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
            Pirate seaScumOne = new Pirate();
            Pirate seaScumTwo = new Pirate();

            seaScumOne.HowsItGoingMate();

            seaScumOne.Brawl(seaScumTwo);

            seaScumOne.PrintOut();
            seaScumTwo.PrintOut();

            Console.ReadLine();
        }
    }
}
