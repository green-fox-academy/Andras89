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

            double hexaWholeHeight = 32;

            IterateSuperMegaHexagon(hexaWholeHeight);
        }

        public void IterateSuperMegaHexagon(double hexaWholeHeight)
        {
            double yIteration = hexaWholeHeight / 2;
            double hexaASide = Math.Sqrt(4 / 3 * yIteration * yIteration);

            double hexaRadius = 2 * hexaASide / Math.Sqrt(3);
            double xIteration = 2 * hexaRadius + hexaASide;

            List<object> hexaProperties = new List<object>();
            Point hexaCenterCoords = new Point(0, 0);

            hexaProperties.Add(hexaCenterCoords);
            hexaProperties.Add(yIteration);
            hexaProperties.Add(hexaASide);
            hexaProperties.Add(hexaRadius);

            for (double yCoord = canvas.Height - yIteration; yCoord >= yIteration; yCoord -= yIteration)
            {

                if ((canvas.Height - yCoord) % (2 * yIteration) == 0)
                {
                    for (double xCoord = hexaRadius; xCoord <= canvas.Width - xIteration;
                                xCoord += (2 * hexaRadius + hexaASide))
                    {
                        hexaProperties[0] = new Point(xCoord, yCoord);
                        DrawHexagon(hexaProperties);
                    }
                }
                else
                {
                    for (double xCoord = 2*hexaRadius + hexaASide / 2; xCoord <= canvas.Width - xIteration;
                                xCoord += (2 * hexaRadius + hexaASide))
                    {
                        hexaProperties[0] = new Point(xCoord, yCoord);
                        DrawHexagon(hexaProperties);
                    }
                }
            }
        }

        public void DrawHexagon(List<object> hexaProperties)
        {
            foxDraw = new FoxDraw(canvas);

            Point centerCoords = (Point)hexaProperties[0];
            double hexaHeight = (double)hexaProperties[1];

            double aSide = (double)hexaProperties[2];
            double radius = (double)hexaProperties[3];

            List<Point> polygonPoints = new List<Point>();

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.FillColor(Colors.Transparent);

            polygonPoints.Add(new Point(centerCoords.X - radius, centerCoords.Y));
            polygonPoints.Add(new Point(centerCoords.X - aSide/2, centerCoords.Y-hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X + aSide / 2, centerCoords.Y - hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X + radius, centerCoords.Y));
            polygonPoints.Add(new Point(centerCoords.X + aSide / 2, centerCoords.Y + hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X - aSide / 2, centerCoords.Y + hexaHeight));

            foxDraw.DrawPolygon(polygonPoints);
        }
    }
}
