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
        public MainWindow()
        {
            InitializeComponent();

            IteratePyramid(10.56454574);
        }

        public void IteratePyramid(double triangleHeight)
        {
            
            double xCordIterate = (Math.Sqrt(4/3*triangleHeight*triangleHeight))/2;
            int counter = 0;

            for (double yCord = canvas.Height; yCord >= 0; yCord -= triangleHeight)
            {
                counter++;
                for (double xCord = xCordIterate * counter; xCord < canvas.Width-(xCordIterate*counter); xCord += xCordIterate*2)
                {
                    DrawTriangle(xCord, yCord, triangleHeight);
                }
            }
        }

        public void DrawTriangle(double xCord, double yCord, double triangleHeight)
        {
            var foxDraw = new FoxDraw(canvas);
            double aSideDividedWithTwo = (Math.Sqrt(4 / 3 * triangleHeight * triangleHeight)) / 2;

            foxDraw.StrokeColor(Colors.Red);

            foxDraw.DrawLine(xCord, yCord, xCord + (aSideDividedWithTwo)*2, yCord, 2);
            foxDraw.DrawLine(xCord, yCord, xCord + aSideDividedWithTwo, yCord - triangleHeight, 2);
            foxDraw.DrawLine(xCord + aSideDividedWithTwo, yCord - triangleHeight,
                             xCord + (aSideDividedWithTwo)*2, yCord, 2);
        }
    }
}
