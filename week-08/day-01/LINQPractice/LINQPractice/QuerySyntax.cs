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

        public Dictionary<int,int> NumFrequency()
        {
            Dictionary<int, int> freq = (from current in InternalIntStructure
                                        group current by current into diffnumber
                                        select new
                                        {
                                            HeadNumber = diffnumber.Key,
                                            HeadCount = diffnumber.Count()
                                        })
                                        .ToDictionary(x => x.HeadCount, x => x.HeadCount);

            return freq;
        }

        public List<int> Square()
        {
            List<int> square = (from current in InternalIntStructure
                                select (int)Math.Pow(current, 2)).ToList();

            return square;
        }

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
