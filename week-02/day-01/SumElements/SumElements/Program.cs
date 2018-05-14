using System;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            int[] r = {54, 23, 66, 12 };
            Console.WriteLine(sumElements(r));

            Console.ReadLine();
        }
        public static int sumElements(int[] array)
        {
            return array[1] + array[2];
        }
    }
}