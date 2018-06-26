using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGoodGuy { get; set; }

        public BankAccount(string name, decimal balance, string animalType, bool isKing, bool isGoodGuy)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsGoodGuy = isGoodGuy;
        }

        public void IncrementBalance(string type)
        {
            if (type.ToLower().Equals(AnimalType.ToLower()))
            {
                if (IsKing)
                {
                    Balance += 100;
                }
                else
                {
                    Balance += 50;
                }
            }
        }
    }
}
