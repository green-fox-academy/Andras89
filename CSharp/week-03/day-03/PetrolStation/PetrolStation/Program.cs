using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Station station = new Station();

            station.Refill(car);

            Console.WriteLine(station.ReturnGasAmount());
            Console.ReadLine();
        }
    }
}
