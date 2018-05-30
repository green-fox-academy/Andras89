using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Reservation : IReservation
    {
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
            FillLetterList();

            Random generateRandom = new Random();

            string output = String.Empty;

            for (int i = 0; i < 8; i++)
            {
                output += Letters[generateRandom.Next(0, Letters.Count)];
            }

            return output;
        }

        public string GetDowBooking()
        {
            Random generateRandom = new Random();

            string output = dow[generateRandom.Next(0, 7)];

            return output;
        }

        private void FillLetterList()
        {
            for (int i = 65; i <= 90; i++)
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
