using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GreenFox;

namespace TreeFractal
{
    class Tree
    {
        private Canvas canvas;

        private Point StartPoint { get; set; }

        private double Pi { get; set; } = Math.PI;
        private int Depth { get; set; }

        private double Theta { get; set; }
        private double DeltaTheta { get; set; }

        private double Length { get; set; }
        private double LengthScale { get; set; }

        public Tree(int Depth, double Length, double LengthScale, double DeltaTheta)
        {
            this.Depth = Depth;
            this.Length = Length;

            this.LengthScale = LengthScale;

            this.DeltaTheta = DeltaTheta * Pi /180;
            Theta = Pi / 2;

            StartPoint = new Point(canvas.Width / 2, canvas.Height * 0.9);
        }
        

    }
}
