using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm theFarmWhereWeLive = new Farm();
            theFarmWhereWeLive = InitializeFarm(theFarmWhereWeLive);

            theFarmWhereWeLive.Slaugther();

            theFarmWhereWeLive.PrintAnimalDatas();

            Console.ReadLine();
        }

        private static Farm InitializeFarm(Farm theFarmWhereWeLive)
        {
            for (int i = 0; i < 10; i++)
            {
                theFarmWhereWeLive.Breed();
            }

            return theFarmWhereWeLive;
        }
    }
}
