using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("Bank")]
    public class BankController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            BankAccount account = new BankAccount("Simba", 2000, "Animal.Lion");            

            return View(account);
        }
    }
}