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

        public Dictionary<int, int> NumFrequency()
        {
            Dictionary<int, int> freq = InternalIntStructure.OrderBy(x => x)
                                                            .GroupBy(g => g)                                                     
                                                            .Select(g => new { HeadNumber = g.Key, HeadCount = g.Count()} )
                                                            .ToDictionary(x => x.HeadNumber, x => x.HeadCount);

            return freq;
        }

        public List<int> Square()
        {
            List<int> square = InternalIntStructure.Select(x => (int)Math.Pow(x, 2)).ToList();

            return square;
        }

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
