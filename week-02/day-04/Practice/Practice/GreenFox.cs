using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GreenFox
{
    public class FoxDraw
    {
        private Canvas Canvas { get; set; }
        private SolidColorBrush LineColor { get; set; } = SystemColors.WindowFrameBrush;
        private SolidColorBrush ShapeColor { get; set; } = new SolidColorBrush(Colors.DarkGreen);

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
        }

        public void BackgroundColor(Color color)
        {
            Canvas.Background = new SolidColorBrush(color);
        }

        public void StrokeColor(Color color)
        {
            LineColor = new SolidColorBrush(color);
        }

        public void FillColor(Color color)
        {
            ShapeColor = new SolidColorBrush(color);
        }

        public void DrawEllipse(double x, double y, double width, double height)
        {
            var ellipse = new Ellipse()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Width = width,
                Height = height
            };

            Canvas.Children.Add(ellipse);
            SetPosition(ellipse, x, y);
        }

        public void DrawLine(Point p1, Point p2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                X1 = p1.X,
                Y1 = p1.Y,
                X2 = p2.X,
                Y2 = p2.Y
            };

            Canvas.Children.Add(line);
        }

        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };

            Canvas.Children.Add(line);
        }

        public void DrawPolygon(IEnumerable<Point> points)
        {
            var polygon = new Polygon()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Points = ListToPointCollection(points)
            };

            Canvas.Children.Add(polygon);
        }

        public void DrawRectangle(double x, double y, double width, double height)
        {
            var rectangle = new Rectangle()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Width = width,
                Height = height
            };

            Canvas.Children.Add(rectangle);
            SetPosition(rectangle, x, y);
        }

        public void AddImage(Image image, double x, double y)
        {
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public PointCollection ListToPointCollection(IEnumerable<Point> points)
        {
            var pointCollection = new PointCollection();

            foreach (var point in points)
            {
                pointCollection.Add(point);
            }

            return pointCollection;
        }
    }
}