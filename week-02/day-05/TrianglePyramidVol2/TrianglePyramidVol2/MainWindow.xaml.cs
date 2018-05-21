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
            double triangleHeight = 30;

            IterateTrianglePyramid(triangleHeight);
        }

        public void IterateTrianglePyramid(double triangleHeight)
        {
            foxDraw = new FoxDraw(canvas);

            double aSide = Math.Sqrt(4 / 3 * triangleHeight * triangleHeight);
            double aSideDivTwo = aSide / 2;

            double aSideDivTwoShaper = 0;
            double aSideShaper = 0;

            foxDraw.StrokeColor(Color.FromRgb(160,20,100));

            for (double i = canvas.Height; i >= 0; i -= triangleHeight)
            {
                foxDraw.DrawLine(0+aSideDivTwoShaper, i, canvas.Width-aSideDivTwoShaper, i, 2);

                foxDraw.DrawLine(0 + aSideShaper, canvas.Height,
                                 canvas.Width/2 + aSideDivTwoShaper, canvas.Height - i, 2);

                foxDraw.DrawLine(canvas.Width / 2 - aSideDivTwoShaper, canvas.Height - i,
                                 canvas.Width - aSideShaper, canvas.Height, 2);

                aSideDivTwoShaper += aSideDivTwo;
                aSideShaper += aSide;
            }

        }
    }
}
