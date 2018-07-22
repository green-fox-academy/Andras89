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

        public Sharpie(string Color, float Width, float InkNumber)
        {
            this.Color = Color;
            this.Width = Width;
            this.InkNumber = InkNumber;
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