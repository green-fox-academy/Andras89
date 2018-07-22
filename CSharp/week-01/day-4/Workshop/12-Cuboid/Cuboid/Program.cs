using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double aSide = double.Parse(Console.ReadLine());
            double bSide = double.Parse(Console.ReadLine());
            double cSide = double.Parse(Console.ReadLine());

            double cuboidVolume = aSide * bSide * cSide;
            double cuboidSurfaceArea = 2 * (aSide * bSide + aSide * cSide + bSide * cSide);

            Console.WriteLine("Volume: " + cuboidVolume);
            Console.WriteLine("Surface Area: " + cuboidSurfaceArea);
            Console.ReadLine();

        }
    }
}