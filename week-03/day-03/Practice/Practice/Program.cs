using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree firstTree = new Tree();
            Tree secondTree = new Tree();
            Tree thirdTree = new Tree();
            Tree fourthTree = new Tree();
            Tree fifthTree = new Tree();

            firstTree.Type = "Birch";
            firstTree.Age = 10;

            firstTree.MultiplyAgeWithAHundred();

            Console.WriteLine(firstTree.Type);
            Console.WriteLine(firstTree.Age);

            Console.ReadLine();
        }
    }
}
