using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // open and read it. The file data represents a tic-tac-toe
            // game result. Return 'X'/'O'/'draw' based on which player
            // has winning situation.

            Console.Write(ticTacResult("win-o.txt"));
            // should print O

            Console.Write(ticTacResult("win-x.txt"));
            // should print X

            Console.Write(ticTacResult("draw.txt"));
            // should print draw

            Console.ReadLine();
        }

        public static string ticTacResult(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string dataStorageLine = sr.ReadLine();
            string[,] matrix = new string[3, 3];
            int indexCounter = 0;

            while(dataStorageLine != null)
            {
                if(dataStorageLine != null)
                {
                    for (int i = 0; i < dataStorageLine.Length; i++)
                    {
                        matrix[indexCounter, i] = dataStorageLine[i].ToString();
                    }
                    indexCounter++;
                }
                dataStorageLine = sr.ReadLine(); 
            }

        }

        public static string MatrixChecker(string[,] matrix)
        {

        }
    }
}