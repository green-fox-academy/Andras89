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
            double hexaHeight = 600;

            DrawHexagon(centerCoords, hexaHeight);

        }

        public void DrawHexagon(Point centerCoords, double hexaWholeHeight)
        {
            FoxDraw foxDraw = new FoxDraw(canvas);

            double hexaHeight = hexaWholeHeight / 2;
            double aSide = Math.Sqrt(4 / 3 * hexaHeight * hexaHeight);
            double radius = 2 * aSide / Math.Sqrt(3);

            List<Point> polygonPoints = new List<Point>();

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.FillColor(Colors.Transparent);

            polygonPoints.Add(new Point(centerCoords.X - radius, centerCoords.Y));
            polygonPoints.Add(new Point(centerCoords.X - aSide / 2, centerCoords.Y - hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X + aSide / 2, centerCoords.Y - hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X + radius, centerCoords.Y));
            polygonPoints.Add(new Point(centerCoords.X + aSide / 2, centerCoords.Y + hexaHeight));
            polygonPoints.Add(new Point(centerCoords.X - aSide / 2, centerCoords.Y + hexaHeight));

            foxDraw.DrawPolygon(polygonPoints);
        }
    }
}
