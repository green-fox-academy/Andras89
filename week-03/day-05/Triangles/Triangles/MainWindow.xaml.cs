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
            double aSide = 500;
            Point center = new Point(300, 300);
            int depth = 4;

            DrawTriangleCarpet(aSide, center, depth);
        }

        private void DrawTriangleCarpet(double aSide, Point center, int depth)
        {
            DrawTriangle(aSide, center);

            double height = aSide * Math.Sqrt(3) / 2;

            Point leftUp = new Point(center.X - aSide / 4, center.Y - height / 6);
            Point rightUp = new Point(center.X + aSide / 4, center.Y - height / 6);
            Point middleDown = new Point(center.X, center.Y + height / 3);

            if (depth > 1)
            {
                DrawTriangleCarpet(aSide / 2, leftUp, depth - 1);
                DrawTriangleCarpet(aSide / 2, rightUp, depth - 1);
                DrawTriangleCarpet(aSide / 2, middleDown, depth - 1);
            }
        }

        public void DrawTriangle(double aSide, Point center)
        {
            FoxDraw foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.Transparent);
            foxDraw.StrokeColor(Colors.Purple);

            double height = aSide * Math.Sqrt(3) / 2;


            Point leftPoint = new Point(center.X - aSide / 2, center.Y - height / 3);
            Point rightPoint = new Point(center.X + aSide / 2, center.Y - height / 3);
            Point middlePoint = new Point(center.X, center.Y + height * 2 / 3);

            List<Point> poly = new List<Point>();
            poly.Add(leftPoint);
            poly.Add(rightPoint);
            poly.Add(middlePoint);

            foxDraw.DrawPolygon(poly);

        }
    }
}
