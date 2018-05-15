using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));

            Console.ReadLine();

            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!

        }

        public static string ContainsSeven(List<int> container)
        {
            string temp = string.Empty;
            bool contain = false;

            for (int i = 0; i < container.Count; i++)
            {
                if (container[i] == 7)
                {
                    contain = true;
                }
            }

            if (contain)
            {
                temp = "Hoooray";
            }
            else
            {
                temp = "Noooooooo";
            }

            return temp;
        }


        /*public static string ContainsSeven(List<int> container)
        {
            string temp = string.Empty;

            if (container.Contains(7))
            {
                temp = "Hooray";
            }
            else
            {
                temp = "Noooooooooooo";
            }

            return temp;
        }*/
    }
}