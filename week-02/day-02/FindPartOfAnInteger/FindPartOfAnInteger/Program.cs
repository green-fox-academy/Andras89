using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and a list of numbers as a parameter
            //  Returns the indeces of the numbers in the list where the first number is part of
            //  Returns an empty list if the number is not part any of the numbers in the list

            //  Example:
            Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            Console.ReadLine();
        }

        public static string SubInt(int number, int[] numberVeryMany)
        {
            string temp = string.Empty;

            for (int i = 0; i < numberVeryMany.Length; i++)
            {
                if(ContainsNumber(number, numberVeryMany[i]))
                {
                    temp += i + ", ";
                }
            }

            return temp;

        }

        public static bool ContainsNumber(int number, int element)
        {
            bool isNumberInIt = false;
            string tempWordOne = number.ToString();
            string tempWordTwo = element.ToString();

            for (int i = 0; i < tempWordTwo.Length; i++)
            {
                if (tempWordOne.Equals(tempWordTwo[i]))
                {
                    isNumberInIt = true;
                }
            }

            return isNumberInIt;
        }
    }
}