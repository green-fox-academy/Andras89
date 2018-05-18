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

            Optical(foxDraw);
        }

        public void Optical(FoxDraw foxDraw)
        {
            for (int i = 1; i < 10; i++)
            {
                foxDraw.DrawLine(0, 0, canvas.Width, (canvas.Height/10)*(i+10), 6);

            }

        }
    }
}
