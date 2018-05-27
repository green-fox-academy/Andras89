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

            double startX = canvas.Width / 2;
            double startY = canvas.Height / 2;

            double radius = 300;
            int depth = 1;

            DrawCircleRecurse(startX, startY, radius, radius, depth);
        }

        private void DrawCircleRecurse(double startX, double startY, double radius1, double radius2, int depth)
        {
        }
    }
}
