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

            Star(foxDraw);
        }

        private void Star(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);

            double center = canvas.Width / 2;

            for (int i = 0; i < center; i += 25)
            {
                foxDraw.DrawLine(center, i , center+i, center, 3);
            }
            for (int i = 0; i < center; i += 25)
            {
                foxDraw.DrawLine(i, center, center, center-i-25, 3);
            }


            for (int i = 0; i < center; i+=25)
            {
                foxDraw.DrawLine(center, (center*2)-i, center - i, center, 3);
            }

            for (int i = 0; i < center; i += 25)
            {
                foxDraw.DrawLine(center, (center*2)-i, center + i, center, 3);
            }
        }
    }
}
