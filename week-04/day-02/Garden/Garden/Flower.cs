using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Flower : Plant
    {
        public Flower(string color) : base(color) { }

        public override void Water(int amount)
        {
            WaterAmount += (amount * 0.75);

            DecideNeedsWater(WaterAmount);
        }

        public override void DecideNeedsWater(double waterAmount)
        {
            if(waterAmount >= 5)
            {
                NeedsWater = false;
            }
        }
    }
}
