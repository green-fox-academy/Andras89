using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTutorialApp.Models;
using MvcTutorialApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcTutorialApp.Controllers
{
    //[Route("")]
    //[Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //[Route("")]
        //[Route("Index")]
        //[Route("Index/{id}")]
        public IActionResult Index()
        {
            Contact contact = new Contact()
            {
                Id = 1,
                FirstName = "Andrew",
                LastName = "Paulson"
            };

            Customer customer = new Customer()
            {
                Id = 2,
                customerName = "Joe"
            };

            HomeIndexViewModel vM = new HomeIndexViewModel()
            {
                Contact = contact,
                Customer = customer
            };

            return View(vM);
        }
    }
}
