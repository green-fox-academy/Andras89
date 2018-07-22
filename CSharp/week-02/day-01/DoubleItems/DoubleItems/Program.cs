using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] numList = { 3, 4, 5, 6, 7 };
            numList = doubleItems(numList);

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }

            Console.ReadLine();
        }
        public static int[] doubleItems(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            return array;
        }
    }
}