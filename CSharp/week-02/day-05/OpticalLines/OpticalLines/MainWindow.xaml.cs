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

            Optical(foxDraw);
        }

        public void Optical(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);

            for (int i = 0; i < canvas.Width; i+=25)
            {
                foxDraw.DrawLine(i, 0, canvas.Width, i+25, 3);
            }

            foxDraw.StrokeColor(Colors.Purple);

            for (int i = 0; i < canvas.Width; i+=25)
            {
                foxDraw.DrawLine(0, i, i+25, canvas.Width, 3);
            }

        }
    }
}
