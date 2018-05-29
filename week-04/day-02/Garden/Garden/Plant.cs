using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Plant
    {
        private string color;
        private bool needsWater;
        private double waterAmount;

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
        }

        public double WaterAmount
        {
            get
            {
                return waterAmount;
            }
        }
    }
}
