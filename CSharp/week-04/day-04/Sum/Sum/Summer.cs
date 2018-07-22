using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Summer
    {
        public int Sum(List<int> numberList)
        {
            if (!numberList.Count.Equals(null))
            {
                int sum = 0;

                foreach (int current in numberList)
                {
                    sum += current;
                }

                return sum;
            }
            else
            {
                return 0;
            }
        }
    }
}
