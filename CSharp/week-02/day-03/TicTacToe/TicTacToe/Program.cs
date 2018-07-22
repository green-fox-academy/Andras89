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
            Console.WriteLine();

            Console.Write(ticTacResult("win-x.txt"));
            // should print X
            Console.WriteLine();

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
            string output = MatrixChecker(matrix);

            return output;
        }

        public static string MatrixChecker(string[,] matrix)
        {
            bool xWins = false;
            bool oWins = false;
            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if(matrix[i,0]==matrix[i,1] && matrix[i, 0] == matrix[i, 2])
                {
                    if (matrix[i, 0] == "X")
                    {
                        xWins = true;
                    }
                    else
                    {
                        oWins = true;
                    }
                }
                else if(matrix[0,i]==matrix[1,i] && matrix[0, i] == matrix[2, i])
                {
                    if (matrix[0, i] == "X")
                    {
                        xWins = true;
                    }
                    else
                    {
                        oWins = true;
                    }
                }
            }
            if(!(xWins || oWins))
            {
                int indexOne = 0;
                int indexTwo = matrix.GetLength(0) - 1;

                if(matrix[indexOne, indexOne]==matrix[indexOne+1, indexOne+1]
                    && matrix[indexOne, indexOne] == matrix[indexTwo, indexTwo])
                {
                    if (matrix[indexOne, indexOne] == "X")
                    {
                        xWins = true;
                    }
                    else
                    {
                        oWins = true;
                    }
                }
                else if(matrix[indexOne, indexTwo] == matrix[indexOne + 1, indexTwo - 1]
                    && matrix[indexOne, indexTwo] == matrix[indexTwo, indexOne])
                {
                    if (matrix[indexOne, indexTwo] == "X")
                    {
                        xWins = true;
                    }
                    else
                    {
                        oWins = true;
                    }
                }
            }

            string output = string.Empty;
            if (xWins)
            {
                output = "X";
            }
            else if (oWins)
            {
                output = "O";
            }
            else
            {
                output = "Draw";
            }

            return output;
        }
    }
}