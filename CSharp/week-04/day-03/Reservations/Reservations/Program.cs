using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservation booking = new Reservation();

            Console.WriteLine($"Booking# {booking.GetCodeBooking()} for {booking.GetDowBooking()}");

            Console.ReadLine();
        }
    }
}
