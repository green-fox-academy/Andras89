using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyProjectApiReboot.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public static long Counter { get; set; }
        public string Content { get; set; }

        public Greeting()
        {
            Counter++;
            Id = Counter;
        }
    }
}
