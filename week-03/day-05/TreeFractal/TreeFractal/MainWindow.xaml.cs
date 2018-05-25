using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GreenFox;

namespace TreeFractal
{
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;


        public MainWindow()
        {
            InitializeComponent();

            Tree oneTree = new Tree(9, 80, 0.86, 27);

            DrawTree(oneTree);
        }
        
        public void DrawTree(Tree tree)
        {
            foxDraw = new FoxDraw(canvas);

            foxDraw.BackgroundColor(Colors.DarkBlue);
            foxDraw.StrokeColor(Colors.Yellow);

            Point newPoint = new Point();
            newPoint.X = tree.StartPoint.X + tree.Length * Math.Cos(tree.Theta);
            newPoint.Y = tree.StartPoint.Y - tree.Length * Math.Sin(tree.Theta);

            foxDraw.DrawLine(tree.StartPoint, newPoint);

            if (tree.Depth > 1)
            {
                DrawTree(new Tree(tree.Depth - 1, tree.Length * tree.LengthScale, tree.LengthScale, tree.DeltaTheta, newPoint, tree.Theta + tree.DeltaTheta));

                DrawTree(new Tree(tree.Depth - 1, tree.Length * tree.LengthScale, tree.LengthScale, tree.DeltaTheta, newPoint, tree.Theta - tree.DeltaTheta));

                DrawTree(new Tree(tree.Depth - 1, tree.Length * tree.LengthScale, tree.LengthScale *1.02, tree.DeltaTheta, newPoint, tree.Theta));
            }
        }
    }
}
