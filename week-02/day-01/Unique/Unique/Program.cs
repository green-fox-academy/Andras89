using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            int[] array = Unique(new int[]{ 1, 11, 34, 11, 52, 61, 1, 34});
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
            //  should print: `[1, 11, 34, 52, 61]`
            Console.ReadLine();
        }
        public static int[] Unique(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < newArray.Length; j++)
                {
                }
            }
            return newArray;
        }
    }
}