using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyProject.Models
{
    public class Greeting
    {
        public static long Counter { get; set; }
        public int Id { get; set; }
        public string Content { get; set; }

        public Greeting()
        {
            Counter++;
            Id += (int)Counter;
        }
    }
}
