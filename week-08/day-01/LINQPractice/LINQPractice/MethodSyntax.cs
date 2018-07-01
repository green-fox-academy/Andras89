using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class MethodSyntax
    {
        public List<int> InternalIntStructure { get; set; }

        public List<int> WithinRange(int low, int high)
        {
            List<int> withinrange = InternalIntStructure.Where(x => x >= low && x <= high).ToList();

            return withinrange;
        }

        public List<int> Even()
        {
            List<int> even = InternalIntStructure.Where(x => x % 2 == 0).ToList();

            return even;
        }
    }
}
