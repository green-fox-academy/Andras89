using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    public class WarApp
    {
        private List<Armada> War = new List<Armada>();

        public WarApp()
        {
            War.Add(new Armada());
            War.Add(new Armada());
        }

        public string FightUltimatePirateFleetBattle()
        {
            string output = String.Empty;

            bool outcome = War[0].Battle(War[1]);

            if (outcome)
            {
                output += $"The winner is the First Fleet. \n" +
                          $"Ship statistics: \n\n" +
                          $"{War[0].ArmadaStatus()}";

                return output;
            }
            else
            {
                output += $"The winner is the Second Fleet. \n" +
                          $"Ship statistics: \n\n" +
                          $"{War[1].ArmadaStatus()}";

                return output;
            }
        }
    }
}
