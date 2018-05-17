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

            //DrawPlus(canvas, foxDraw);
            //DrawDifferentSideColorBox(canvas, foxDraw);
            DrawDiagonal(canvas, foxDraw);
        }

        public void DrawDiagonal(Canvas canvas, FoxDraw foxDraw)
        {
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, canvas.Width, canvas.Height, 10);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(canvas.Width, 0, 0, canvas.Height, 10);

        }

        public void DrawPlus(Canvas canvas, FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, canvas.Width / 2, canvas.Height, canvas.Width / 2, 10);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width / 2, 0, canvas.Width / 2, canvas.Height, 10);
        } 
         public void DrawDifferentSideColorBox(Canvas canvas, FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(canvas.Width / 4, canvas.Height / 4,
                             canvas.Height / 4, canvas.Height / 4 * 3, 10);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Height / 4, canvas.Height / 4 * 3,
                             canvas.Height / 4 * 3, canvas.Height / 4 * 3, 10);

            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(canvas.Width / 4, canvas.Height / 4,
                             canvas.Height / 4*3, canvas.Height / 4, 10);

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(canvas.Height / 4*3, canvas.Height / 4,
                             canvas.Height / 4 * 3, canvas.Height / 4 * 3, 10);

        }

    }
}
