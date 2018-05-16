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
            var foxDraw = new FoxDraw(canvas);

            DrawGreenLines(foxDraw);
            DrawEllipse(foxDraw);
            DrawRectangle(foxDraw);
            DrawGreenPolygon(foxDraw);
        }

        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 10, 100, 10);

            var startPoint = new Point(0, 20);
            var endPoint = new Point(100, 20);
            foxDraw.DrawLine(startPoint, endPoint);
        }

        public static void DrawEllipse(FoxDraw foxDraw)
        {
            foxDraw.DrawEllipse(10, 10, 150, 50);
        }

        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(10, 10, 150, 50);
        }

        public static void DrawGreenPolygon(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(10, 10));
            points.Add(new Point(40, 210));
            points.Add(new Point(170, 190));
            points.Add(new Point(130, 40));
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }
}
