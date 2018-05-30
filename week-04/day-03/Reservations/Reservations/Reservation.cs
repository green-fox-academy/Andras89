using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Reservation : IReservation
    {
        private readonly Random generateRandom;
        private string[] dow;
        private List<char> letters;

        public Reservation()
        {
            dow = new string[7]
            {
                "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"
            };

            letters = new List<char>();
        }

        public string[] Dow { get => dow; }
        public List<char> Letters { get => letters; set => letters = value; }

        public string GetCodeBooking()
        {
            string output = dow[generateRandom.Next(0, 7)];

            return output;
        }

        public string GetDowBooking()
        {
            throw new NotImplementedException();
        }

        private void FillLetterList()
        {
            for (int i = 65; i <= 90; i++)
            {
                Letters.Add((char)i);
            }

            for (int i = 97; i <= 122; i++)
            {
                Letters.Add((char)i);
            }

            for (int i = 48; i <= 57; i++)
            {
                Letters.Add((char)i);
            }
        }
    }
}
