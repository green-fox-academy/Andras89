using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("Bank")]
    public class BankController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            BankAccount account = new BankAccount("Simba", 2000, "Lion");

            return View(account);
        }

        [HttpGet("AccountInfo")]
        public IActionResult AccountInfo()
        {
            BankAccountInfoViewModel bankDatabase = new BankAccountInfoViewModel()
            {
                BankAccountDatabase = new List<BankAccount>
                {
                    new BankAccount("Simba", 5000, "Lion"),
                    new BankAccount("Musafa", 32000, "Lion"),
                    new BankAccount("Zazu", 3000, "Bird"),
                    new BankAccount("Timon", 20, "Meerkat"),
                    new BankAccount("Pumba", 0, "Boar")
                }
            };

            return View(bankDatabase);
        }
    }
}