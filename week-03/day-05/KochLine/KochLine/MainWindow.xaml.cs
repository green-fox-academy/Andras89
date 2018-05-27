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

            Point start = new Point(0, canvas.Height / 2);
            Point end = new Point(canvas.Width, canvas.Height / 2);

            DrawKochLine(start, end);
        }

        public void DrawKochLine(Point start, Point end)
        {
            
        }
    }
}
