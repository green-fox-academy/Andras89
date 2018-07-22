using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            List<string> planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList = PutSaturn(planetList);

            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.
            for (int i = 0; i < planetList.Count; i++)
            {
                Console.Write(planetList[i] + " ");
            }

            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"

            Console.ReadLine();
        }

        public static List<string> PutSaturn(List<string> planetPlacer)
        {
            planetPlacer.Insert(5, "Saturn");
            return planetPlacer;
        }
    }
}