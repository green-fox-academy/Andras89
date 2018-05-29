using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Garden
    {
        private List<Plant> garden;

        public Garden()
        {
            garden = new List<Plant>()
            {
                new Flower("yellow"),
                new Flower("blue"),
                new Tree("purple"),
                new Tree("orange")
            };
        }

        public string Water(double amount)
        {
            string output = $"Watering with {amount}\n";

            amount /= GetAmountOfWateringNeeded();

            for (int i = 0; i < garden.Count; i++)
            {
                garden[i].Water(amount);
            }

            output += Info();

            return output;
        }

        private int GetAmountOfWateringNeeded()
        {
            int counter = 0;

            for (int i = 0; i < garden.Count; i++)
            {
                if(garden[i].NeedsWater == false)
                {
                    counter++;
                }
            }

            return counter;
        }

        public string Info()
        {
            string output = String.Empty;

            for (int i = 0; i < garden.Count; i++)
            {
                output += $"The {garden[i].Color} {garden[i]} {PrintNeed(garden[i])} water.\n";
            }

            return output;
        }

        private string PrintNeed(Plant plant)
        {
            if(plant.NeedsWater == false)
            {
                return "needs";
            }
            else
            {
                return "doesn't need";
            }
        }
    }
}
