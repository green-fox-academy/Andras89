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
            //DrawDiagonal(canvas, foxDraw);

            //DrawToMiddle(40, 80);
            //DrawHorizontalLinesFromCord(100, 100);

            CenteredSquare(foxDraw);
        }

        public void CenteredSquare(FoxDraw foxDraw)
        {
            // Draw a green 10x10 square to the canvas' center.
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(canvas.Width / 2 - 5, canvas.Height / 2 - 5,
                             canvas.Width / 2 + 5, canvas.Height / 2 - 5, 2);
            foxDraw.DrawLine(canvas.Width / 2 - 5, canvas.Height / 2 + 5,
                             canvas.Width / 2 + 5, canvas.Height / 2 + 5, 2);
            foxDraw.DrawLine(canvas.Width / 2 - 5, canvas.Height / 2 - 5,
                             canvas.Width / 2 - 5, canvas.Height / 2 + 5, 2);
            foxDraw.DrawLine(canvas.Width / 2 + 5, canvas.Height / 2 - 5,
                             canvas.Width / 2 + 5, canvas.Height / 2 + 5, 2);
        }

        public void DrawHorizontalLinesFromCord(int x, int y)
        {
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Orange);

            for (int i = 1; i <= 3; i++)
            {
                foxDraw.DrawLine(x, y*i, x + 50, y*i, 10);
            }
        }

        public void DrawToMiddle(int x, int y)
        {
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Red);
            for (int i = 1; i <= 3; i++)
            {
                foxDraw.DrawLine(x*i, y*i, canvas.Width / 2, canvas.Height / 2, 10);
            }
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
