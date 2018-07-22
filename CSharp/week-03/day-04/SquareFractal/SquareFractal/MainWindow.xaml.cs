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
            foxDraw = new FoxDraw(canvas);

            Point upperCoord = new Point(0,0);
            Point lowerCoord = new Point(canvas.Width, canvas.Height);

            Fractal(upperCoord, lowerCoord);
        }

        public void Fractal(Point upperCoord, Point lowerCoord)
        {
            foxDraw = new FoxDraw(canvas);


        }
    }
}
