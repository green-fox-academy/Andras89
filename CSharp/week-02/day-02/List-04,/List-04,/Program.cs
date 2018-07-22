using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"

            Console.ReadLine();
        }

        public static string Sweets(List<object> manyRandomThingsInHere)
        {
            string temp = string.Empty;

            foreach (var item in manyRandomThingsInHere)
            {
                if(item is bool)
                {
                    temp += "Ice cream, ";
                }else if(item is int)
                {
                    temp += "Croissant, ";
                }
                else
                {
                    temp += item + ", ";
                }
            }

            return temp;
        }
    }
}