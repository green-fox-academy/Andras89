using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels
{
    public class BankAccountInfoViewModel
    {
        public List<BankAccount> BankAccountDatabase { get; set; }

        public void AnimalChecker(string type)
        {
            foreach (var animal in BankAccountDatabase)
            {
                animal.IncrementBalance(type);
            }
        }
    }
}
