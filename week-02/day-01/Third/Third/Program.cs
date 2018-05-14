using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `q`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `q`
            int[] q = { 4, 5, 6, 7 };
            Console.WriteLine(third(q));

            Console.ReadLine();
        }

        public static int third(int[] array)
        {
            return array[2];
        }
    }
}