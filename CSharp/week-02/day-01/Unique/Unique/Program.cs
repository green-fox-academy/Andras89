using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            int[] array = Unique(new int[] { 1, 11, 34, 11, 52, 61, 1, 34 });

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            /* List<int> list = Unique(new int[]{ 1, 11, 34, 11, 52, 61, 1, 34});
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+ " ");
            }*/
            //  should print: `[1, 11, 34, 52, 61]`
            Console.ReadLine();
        }

        public static int[] Unique(int[] array)
        {
            int[] tempArray = new int[array.Length];
            bool contains;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                contains = true;
                
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (array[i] == tempArray[j])
                    {
                        contains = false;
                    }
                }
                if (contains)
                {
                    tempArray[index] = array[i];
                    index++;
                }
            }

            int counter = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] != 0)
                {
                    counter++;
                }
            }

            int[] resultArray = new int[counter];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = tempArray[i];
            }

            return resultArray;
        }
        /*public static List<int> Unique(int[] array)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!list.Contains(array[i]))
                {
                    list.Add(array[i]);
                }
            }
            return list;
        }*/
    }
}