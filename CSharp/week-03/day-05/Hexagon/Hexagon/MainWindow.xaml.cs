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

            Point centerCoords = new Point(canvas.Width / 2, canvas.Height / 2);
            double hexaWholeHeight = 600;

            int depth = 6;

            HexaRecursion(centerCoords, hexaWholeHeight, depth);
        }

        public void HexaRecursion(Point centerCoords, double hexaWholeHeight, int depth)
        {
            DrawHexagon(centerCoords, hexaWholeHeight);

            double hexaHeight = hexaWholeHeight / 2;
            double aSide = Math.Sqrt(4 / 3 * hexaHeight * hexaHeight);

            if (depth > 1)
            {
                Point first = new Point(centerCoords.X - aSide / 3 * 2, centerCoords.Y);
                HexaRecursion(first, hexaWholeHeight / 3, depth - 1);

                Point second = new Point(centerCoords.X - aSide / 3, centerCoords.Y - hexaWholeHeight / 3);
                HexaRecursion(second, hexaWholeHeight / 3, depth - 1);

                Point third = new Point(centerCoords.X + aSide / 3, centerCoords.Y - hexaWholeHeight / 3);
                HexaRecursion(third, hexaWholeHeight / 3, depth - 1);

                Point fourth = new Point(centerCoords.X + aSide / 3 * 2, centerCoords.Y);
                HexaRecursion(fourth, hexaWholeHeight / 3, depth - 1);

                Point fifth = new Point(centerCoords.X + aSide / 3, centerCoords.Y + hexaWholeHeight / 3);
                HexaRecursion(fifth, hexaWholeHeight / 3, depth - 1);

                Point sixth = new Point(centerCoords.X - aSide / 3, centerCoords.Y + hexaWholeHeight / 3);
                HexaRecursion(sixth, hexaWholeHeight / 3, depth - 1); 
            }

        }

        public void DrawHexagon(Point centerCoords, double hexaWholeHeight)
        {
            FoxDraw foxDraw = new FoxDraw(canvas);

            double hexaHeight = hexaWholeHeight / 2;
            double aSide = Math.Sqrt(4 / 3 * hexaHeight * hexaHeight);

            List<Point> polygonPoints = new List<Point>();

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.FillColor(Colors.Transparent);

            polygonPoints.Add(new Point(centerCoords.X - aSide, centerCoords.Y));
            polygonPoints.Add(new Point(centerCoords.X - aSide / 2, centerCoords.Y - hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X + aSide / 2, centerCoords.Y - hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X + aSide, centerCoords.Y));
            polygonPoints.Add(new Point(centerCoords.X + aSide / 2, centerCoords.Y + hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X - aSide / 2, centerCoords.Y + hexaHeight));

            foxDraw.DrawPolygon(polygonPoints);
        }
    }
}
