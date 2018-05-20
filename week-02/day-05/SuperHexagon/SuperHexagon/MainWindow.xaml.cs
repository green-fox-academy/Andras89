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
            Point hexaCenterCoords = new Point(300, 300);
            double hexaHeight = 10;

            List<object> hexaProperties = new List<object>();
            hexaProperties.Add(hexaCenterCoords);
            hexaProperties.Add(hexaHeight);

            DrawHexagon(hexaProperties);
        }

        private void DrawHexagon(List<object> hexagonCoordAndHeight)
        {
            foxDraw = new FoxDraw(canvas);
            double hexaHeight = (double)hexagonCoordAndHeight[1] / 2;
            Point centerCoords = (Point)hexagonCoordAndHeight[0];

            double aSide = Math.Sqrt(4/3 * hexaHeight * hexaHeight);
            double radius = 2 * aSide / Math.Sqrt(3);
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
