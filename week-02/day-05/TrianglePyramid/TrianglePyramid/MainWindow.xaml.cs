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
            var foxDraw = new FoxDraw(canvas);
            //DrawTriangle(200, 200, 100);
            IteratePyramid(50);
        }

        private void IteratePyramid(double triangleHeight)
        {
            
            double xCordIterate = (Math.Sqrt(4/3*triangleHeight*triangleHeight))/2;
            //double xCord = 0;
            double yCord = canvas.Height;

            for (int i = 0; i < canvas.Height/triangleHeight; i++)
            {

                for (double xCord = xCordIterate * i; xCord < canvas.Width-(xCordIterate*i); xCord += xCordIterate*2)
                {
                    DrawTriangle(xCord, yCord, triangleHeight);
                }
                yCord -= triangleHeight;
            }
            

        }

        private void DrawTriangle(double xCord, double yCord, double triangleHeight)
        {
            var foxDraw = new FoxDraw(canvas);
            double aSideDividedWithTwo = (Math.Sqrt(4 / 3 * triangleHeight * triangleHeight)) / 2;

            foxDraw.DrawLine(xCord, yCord, xCord + (aSideDividedWithTwo)*2, yCord, 2);
            foxDraw.DrawLine(xCord, yCord, xCord + aSideDividedWithTwo, yCord - triangleHeight, 2);
            foxDraw.DrawLine(xCord + aSideDividedWithTwo, yCord - triangleHeight,
                             xCord + (aSideDividedWithTwo)*2, yCord, 2);
        }
    }
}
