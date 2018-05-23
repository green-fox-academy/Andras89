using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Sharpie
    {
        private string Color;
        private float Width;
        private float InkNumber;

        public Sharpie(string Color, float Width)
        {
            this.Color = Color;
            this.Width = Width;
            InkNumber = 100;
        }

        public void Use()
        {
            if(InkNumber > 10)
            {
                InkNumber -= 10;
            }
        }

        public float NumberOfUsesLeft()
        {
            return InkNumber;
        }
    }
}