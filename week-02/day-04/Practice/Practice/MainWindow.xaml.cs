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

            //CenteredSquare(foxDraw);
            //FourRectangles(foxDraw);

            //SquarePositioning(50, 50);
            //CenterBoxFunction(50);

            //RainBowFunction(50, Colors.Red);
            //StarryNight(foxDraw, 200);

            CheckerBoard(foxDraw);

        }

        public void CheckerBoard(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.Black);
            for (double i = 0; i < canvas.Height/10; i++)
            {
                for (double j = 0; j < canvas.Width/10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        foxDraw.DrawRectangle(i*10, j*10, 10, 10);
                    }
                }
            }
        }

        public void StarryNight(FoxDraw foxDraw, int numberOfStars)
        {
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)
            foxDraw.BackgroundColor(Colors.Black);
            Random randomPos = new Random();

            int width = (int)canvas.Width;
            int heigth = (int)canvas.Height;
            int size = 0;

            Color[] colorContainer = {Colors.Gray, Colors.DimGray, Colors.LightSlateGray, Colors.SlateGray };

            for (int i = 0; i < numberOfStars; i++)
            {
                size = randomPos.Next(3, 10);
                foxDraw.FillColor(colorContainer[randomPos.Next(0,3)]);
                foxDraw.DrawRectangle(randomPos.Next(0, width), randomPos.Next(0, heigth), size, size);
                
            }
        }

        public void RainBowFunction(double sizeOfBox, Color color)
        {
            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares,
            // all squares should be centered, but growing in size

            var foxDraw = new FoxDraw(canvas);
            Random randomColor = new Random();
            Color[] colorContainer = { Colors.Red, Colors.Purple, Colors.Yellow, Colors.Green,
                                       Colors.Orange, Colors.Pink, Colors.Blue, Colors.Bisque,
                                       Colors.BlanchedAlmond, Colors.Moccasin};

            for (int i = 3; i >= 1; i--)
            {
                foxDraw.FillColor(colorContainer[randomColor.Next(0, 9)]);

                foxDraw.DrawRectangle(canvas.Width / 2 - (sizeOfBox / 2)*i, canvas.Height / 2 - (sizeOfBox / 2)*i,
                                      sizeOfBox * i, sizeOfBox * i);

            }

        }

        public void CenterBoxFunction(double sizeOfBox)
        {
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            var foxDraw = new FoxDraw(canvas);
            double centerWidth = canvas.Width / 2;
            double centerHeight = canvas.Height / 2;
            double size = 0;

            foxDraw.StrokeColor(Colors.Purple);

            for (int i = 1; i <= 3; i++)
            {
                size = sizeOfBox * i;

                foxDraw.DrawLine(centerWidth - size / 2, centerHeight - size / 2,
                                 centerWidth + size / 2, centerHeight - size / 2, 6);
                foxDraw.DrawLine(centerWidth - size / 2, centerHeight - size / 2,
                                 centerWidth - size / 2, centerHeight + size / 2, 6);
                foxDraw.DrawLine(centerWidth + size / 2, centerHeight + size / 2,
                                 centerWidth + size / 2, centerHeight - size / 2, 6);
                foxDraw.DrawLine(centerWidth + size / 2, centerHeight + size / 2,
                                 centerWidth - size / 2, centerHeight + size / 2, 6);
            }
        }

        public void SquarePositioning(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Blue);

            for (int i = 1; i <= 3; i++)
            {
                foxDraw.DrawLine(x, y, (x + 50) * i, y, 6);
                foxDraw.DrawLine(x, y, x, (y+50) * i, 6);
                foxDraw.DrawLine((x + 50) * i, (y + 50) * i, (x + 50) * i, y, 6);
                foxDraw.DrawLine((x + 50) * i, (y + 50) * i, x, (y + 50) * i, 6);
            }

        }

        public void FourRectangles(FoxDraw foxDraw)
        {
            for (int i = 1; i <= 4; i++)
            {
                foxDraw.DrawRectangle(25*i*i, 25*i*i, 50*i, 50*i);
            }
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
