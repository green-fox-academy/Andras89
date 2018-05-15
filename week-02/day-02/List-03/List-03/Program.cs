using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"

            Console.ReadLine();
        }

        public static string AppendA(List<string> container)
        {
            string temp = String.Empty;

            for (int i = 0; i < container.Count; i++)
            {
                if(i == container.Count - 1)
                {
                    temp += container[i] + "a";
                }
                else
                {
                    temp += container[i] + "a, ";
                }
            }

            return temp;
        }
    }
}