using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = { "first", "second", "third" };
            abc = SwapElement(abc);

            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }

            Console.ReadLine();
        }
        public static string[] SwapElement(string[] array)
        {
            string temp = "";
            temp = array[0];
            array[0] = array[2];
            array[2] = temp;

            return array;
        } 
    }
}