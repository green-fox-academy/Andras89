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
    [Route("")]
    public class BankController : Controller
    {
        public static BankAccountInfoViewModel bankDatabase = new BankAccountInfoViewModel()
        {
            BankAccountDatabase = new List<BankAccount>
                {
                    new BankAccount(){ Name="Simba", Balance=5000, AnimalType="Lion", IsKing=true, IsGoodGuy=true },
                    new BankAccount(){ Name="Mufasa", Balance=32000, AnimalType="Lion", IsKing=true, IsGoodGuy=true },
                    new BankAccount(){ Name="Zazu", Balance=3000, AnimalType="Bird", IsKing=false, IsGoodGuy=true },
                    new BankAccount(){ Name="Timon", Balance=20, AnimalType="Meerkat", IsKing=false, IsGoodGuy=true },
                    new BankAccount(){ Name="Pumba", Balance=0, AnimalType="Boar", IsKing=false, IsGoodGuy=true },
                    new BankAccount(){ Name="Scar", Balance=400000, AnimalType="Lion", IsKing=true, IsGoodGuy=false }
                }
            };

        [HttpGet("Index")]
        public IActionResult Index()
        {
            BankAccount account = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion",
                IsKing = true,
                IsGoodGuy = true
            };

            return View(account);
        }

        [HttpGet("AccountInfo")]
        [Route("")]
        public IActionResult AccountInfo()
        {   
            return View(bankDatabase);
        }

        [HttpPost("IncrementBalance")]
        public IActionResult IncrementBalance(string type)
        {
            bankDatabase.AnimalChecker(type);

            return RedirectToAction("AccountInfo");
        }

        [HttpPost("AddNewAccount")]
        public IActionResult AddNewAccount(BankAccount account)
        {
            bankDatabase.BankAccountDatabase.Add(account);

            return RedirectToAction("AccountInfo");
        }
    }
}