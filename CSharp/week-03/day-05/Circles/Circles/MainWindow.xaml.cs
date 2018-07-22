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

            double startX = 0;
            double startY = 0;

            double radius = 600;
            int depth = 2;

            DrawCircleRecurse(startX, startY, radius, radius, depth);
        }

        private void DrawCircleRecurse(double startX, double startY, double radius1, double radius2, int depth)
        {
            DrawCircle(startX, startY, radius1, radius1);

            double middleUpX = radius1 / 4;
            double middleUpY = startY;

            double leftRightDownY = radius1 / 2 - Math.Sin(Math.PI / 6) * radius1 / 4;
            double leftDownX =radius1 / 4 - Math.Cos(Math.PI / 6) * (radius1 / 4);
            double rightDownX = radius1 / 2 - radius1 / 4 + Math.Cos(Math.PI / 6) * (radius1 / 4);

            if (depth > 1)
            {
                DrawCircleRecurse(middleUpX, middleUpY, radius1 / 2, radius2 / 2, depth - 1);
                DrawCircleRecurse(leftDownX, leftRightDownY, radius1 / 2, radius2 / 2, depth - 1);
                DrawCircleRecurse(rightDownX, leftRightDownY, radius1 / 2, radius2 / 2, depth - 1); 
            }
        }

        public void DrawCircle(double startX, double startY, double radius1, double radius2)
        {
            FoxDraw foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Orange);
            foxDraw.FillColor(Colors.Transparent);

            foxDraw.DrawEllipse(startX, startY, radius1, radius1);
        }
    }
}
