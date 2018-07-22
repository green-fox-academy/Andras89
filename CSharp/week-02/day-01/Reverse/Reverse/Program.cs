using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = { 3, 4, 5, 6, 7 };
            aj = ReverseArray(aj);

            for (int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i]);
            }

            Console.ReadLine();
        }
        public static int[] ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[array.Length - (i + 1)] = array[i];
            }
            return newArray;
        }
    }
}