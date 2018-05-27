using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    public class BattleApp
    {
        private List<PirateShip> BattleField = new List<PirateShip>();
        
        public BattleApp()
        {
            BattleField.Add(new PirateShip());
            BattleField.Add(new PirateShip());

            BattleField[0].FillShip();
            BattleField[1].FillShip();
        }

        public string Battle()
        {
            string output = String.Empty;

            output += $"{BattleField[0].ShipStatus()}{BattleField[1].ShipStatus()} \n" +
                      $"Does the first ship win: {BattleField[0].Battle(BattleField[1])} \n\n" +
                      $"{BattleField[0].ShipStatus()}{BattleField[1].ShipStatus()}";

            return output;
        }
    }
}
