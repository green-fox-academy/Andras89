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
            DrawTriangle(foxDraw, 200, 200, 100);
        }



        private void DrawTriangle(FoxDraw foxDraw, double xCord, double yCord, double triangleHeight)
        {
            double aSideDividedWithTwo = (Math.Sqrt(4 / 3 * triangleHeight * triangleHeight)) / 2;

            foxDraw.DrawLine(xCord, yCord, xCord + aSideDividedWithTwo, yCord + triangleHeight, 2);
            foxDraw.DrawLine(xCord, yCord, xCord - aSideDividedWithTwo, yCord + triangleHeight, 2);
            foxDraw.DrawLine(xCord + aSideDividedWithTwo, yCord + triangleHeight,
                             xCord - aSideDividedWithTwo, yCord + triangleHeight, 2);

        }
    }
}
