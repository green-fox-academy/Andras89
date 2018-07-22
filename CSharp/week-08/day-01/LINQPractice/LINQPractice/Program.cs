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

            Console.WriteLine("EVEN 1-30:");
            lambda.Even().ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();
            query.Even().ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();

            Console.WriteLine("WithinRange 6-17:");
            lambda.WithinRange(6, 17).ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();
            query.WithinRange(6, 17).ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();

            lambda.InternalIntStructure = lambda.WithinRange(6, 17);
            query.InternalIntStructure = query.WithinRange(6, 17);
            Console.WriteLine("Square 6-17:");
            lambda.Square().ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();
            query.Square().ForEach(x => Console.Write($"{x}; "));
            Console.WriteLine();

            lambda.InternalIntStructure = new List<int> { 2, 5, 7, 2, 2, 5, 9, 9, 5, 2, 2, 3, 1, 1, 1, 2};
            query.InternalIntStructure = new List<int> { 2, 5, 7, 2, 2, 5, 9, 9, 5, 2, 2, 3, 1, 1, 1, 2 };
            Console.WriteLine("NumberFreq:");
            lambda.NumFrequency().ToList().ForEach(x => Console.Write($"{x.Key}: {x.Value}; "));
            Console.WriteLine();
            query.NumFrequency().ToList().ForEach(x => Console.Write($"{x.Key}: {x.Value}; "));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
