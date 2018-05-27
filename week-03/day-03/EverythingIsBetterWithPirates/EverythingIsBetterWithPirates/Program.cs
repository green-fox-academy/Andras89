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
            BattleApp battle = new BattleApp();

            Console.WriteLine(battle.Battle());

            Console.ReadLine();
        }
    }
}
