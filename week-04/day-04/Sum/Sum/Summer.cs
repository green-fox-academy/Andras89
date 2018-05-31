using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Summer
    {
        public List<int> NumberList { get; set; }

        public int Sum()
        {
            int sum = 0;

            foreach ( int current in NumberList)
            {
                sum += current;
            }

            return sum;
        }
    }
}
