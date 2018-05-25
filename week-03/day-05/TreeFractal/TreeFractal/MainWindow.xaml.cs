using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GreenFox;

namespace Drawing
{
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;


        public MainWindow()
        {
            InitializeComponent();
            double pi = Math.PI;
            DrawTree(new Point(canvas.Width / 2, canvas.Height / 3 * 2), 6, 80, pi/2, pi/3, 0.8);
        }

        public void DrawTree(Point startPoint, int depth, double length, double theta,
                             double deltaTheta, double lengthScale)
        {
            foxDraw = new FoxDraw(canvas);

            foxDraw.BackgroundColor(Colors.DarkBlue);

            Point newPoint = new Point();
            newPoint.X = startPoint.X + length * Math.Cos(theta);
            newPoint.Y = startPoint.Y - length * Math.Sin(theta);

            foxDraw.DrawLine(startPoint, newPoint);

            if (depth > 1)
            {
                DrawTree(newPoint, depth - 1, length * lengthScale, theta + deltaTheta, deltaTheta, lengthScale);

                DrawTree(newPoint, depth - 1, length * lengthScale, theta - deltaTheta, deltaTheta, lengthScale);

                DrawTree(newPoint, depth - 1, length * lengthScale, theta, deltaTheta, lengthScale);

            }


        }
    }
}
