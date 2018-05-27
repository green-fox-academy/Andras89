using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    public class Armada
    {
        private List<PirateShip> Fleet = new List<PirateShip>();

        public Armada()
        {
            for (int i = 0; i < 20; i++)
            {
                Fleet.Add(new PirateShip());
                Fleet[i].FillShip();
            }
        }

        public bool Battle(Armada otherFleet)
        {
            bool fleetSunk;

            do
            {
                bool battleResult = Fleet[0].Battle(otherFleet.Fleet[0]);

                if (battleResult)
                {
                    otherFleet.Fleet.RemoveAt(0);
                }
                else
                {
                    Fleet.RemoveAt(0);
                }

                fleetSunk = Fleet.Count > 0 && otherFleet.Fleet.Count > 0;

            } while (fleetSunk);

            return Fleet.Count > 0;
        }

        public string ArmadaStatus()
        {
            string output = String.Empty;

            for (int i = 0; i < Fleet.Count; i++)
            {
                output += i+1+ ". Ship:\n" + Fleet[i].ShipStatus() + "\n";
            }

            return output;
        }
    }
}
