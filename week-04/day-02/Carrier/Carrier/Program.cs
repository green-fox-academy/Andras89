using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier ussBenedict = new Carrier(5000, 2300);
            Carrier ussOriga = new Carrier(4000, 200);

            ussBenedict.Add(new F35());
            ussBenedict.Add(new F35());
            ussBenedict.Add(new F35());

            ussBenedict.Add(new F16());
            ussBenedict.Add(new F16());

            Console.WriteLine(ussBenedict.Fight(ussOriga));

            Console.ReadLine();
        }
    }
}
