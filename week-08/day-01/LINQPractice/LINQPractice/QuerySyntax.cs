using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
     public class QuerySyntax
    {
        public List<int> InternalIntStructure { get; set; }

        public List<int> WithinRange(int low, int high)
        {
            List<int> withinRange = (from current in InternalIntStructure
                                     where current >= low && current <= high
                                     select current).ToList();

            return withinRange;
        }

        public List<int> Even()
        {
            List<int> even = (from current in InternalIntStructure
                             where current % 2 == 0
                             select current).ToList();

            return even;
        }
    }
}
