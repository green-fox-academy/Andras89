﻿using System;
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


        }
    }
}
