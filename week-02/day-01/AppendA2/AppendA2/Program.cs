using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            string[] animals = { "kuty", "macsk", "cic" };
            animals = AppenA(animals);

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
            Console.ReadLine();
        }
        public static string[] AppenA(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += "a";
            }
            return array;
        }
    }
}