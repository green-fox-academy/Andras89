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
    public class Tree
    {
        public static readonly Canvas canvas;

        public Point StartPoint { get; set; }

        public double Pi { get; set; } = Math.PI;
        public int Depth { get; set; }

        public double Theta { get; set; }
        public double DeltaTheta { get; set; }

        public double Length { get; set; }
        public double LengthScale { get; set; }

        public Tree(int Depth, double Length, double LengthScale, double DeltaTheta)
        {
            this.Depth = Depth;
            this.Length = Length;

            this.LengthScale = LengthScale;

            this.DeltaTheta = DeltaTheta * Pi /180;
            Theta = Pi / 2;

            StartPoint = new Point(300, 500);
        }

        public Tree(int Depth, double Length, double LengthScale, double DeltaTheta, Point StartPoint, double Theta)
        {
            this.StartPoint = StartPoint;

            this.Depth = Depth;
            this.Length = Length;

            this.Theta = Theta;
            this.DeltaTheta = DeltaTheta;

            this.LengthScale = LengthScale;

        }
    }
}
