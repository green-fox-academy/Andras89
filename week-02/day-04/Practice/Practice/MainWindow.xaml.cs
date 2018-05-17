using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GreenFox;
using System.Windows.Shapes;

namespace Drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            DrawPlus(canvas, foxDraw);
        }

        public void DrawPlus(Canvas canvas, FoxDraw foxDraw)
        {
            foxDraw.DrawLine(canvas.Width / 2, 0, canvas.Width / 2, canvas.Height);
            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawLine(0, canvas.Width / 2, canvas.Height, canvas.Width / 2);
        } 
    }
}
