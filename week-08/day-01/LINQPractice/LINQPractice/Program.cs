using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> practiceRange = Enumerable.Range(1, 30).ToList();

            MethodSyntax lambda = new MethodSyntax() { InternalIntStructure = practiceRange };
            QuerySyntax query = new QuerySyntax() { InternalIntStructure = practiceRange };

            Console.WriteLine("EVEN:");
            lambda.Even().ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();
            query.Even().ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();

            Console.WriteLine("WithinRange:");
            lambda.WithinRange(6, 17).ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();
            query.WithinRange(6, 17).ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
