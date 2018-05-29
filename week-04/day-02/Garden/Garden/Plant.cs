using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Plant
    {
        private string color;
        private bool needsWater;
        private double waterAmount;

        public Plant(string color)
        {
            this.color = color;
            needsWater = true;
            waterAmount = 0;
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public bool NeedsWater
        {
            get
            {
                return needsWater;
            }
            set
            {
                needsWater = value;
            }
        }

        public double WaterAmount
        {
            get
            {
                return waterAmount;
            }
            set
            {
                waterAmount = value;
            }
        }

        public virtual void Water(int amount)
        {

        }
    }
}
