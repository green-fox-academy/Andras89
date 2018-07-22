using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            int number = int.Parse(Console.ReadLine());
            string temp = "";
            int counter = 0;

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == number-1)
                {
                    for (int j = 0; j < number; j++)
                    {
                        temp += "%";
                    }
                    Console.WriteLine(temp);
                    temp = "";
                }
                else
                {
                    temp += "%";
                    for (int j = 1; j < number-1; j++)
                    {
                        if(j == counter)
                        {
                            temp += "%";
                        }
                        else
                        {
                            temp += " ";
                        }
                    }
                    temp += "%";
                    Console.WriteLine(temp);
                    temp = "";
                }
                counter++;
            }
            Console.ReadLine();
        }
    }
}