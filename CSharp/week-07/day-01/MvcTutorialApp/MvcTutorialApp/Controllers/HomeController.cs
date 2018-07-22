using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTutorialApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcTutorialApp.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("Index")]
        [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            Contact contact = new Contact()
            {
                id = id,
                firstName = "Andrew",
                lastName = "Paulson"
            };

            return View(contact);
        }
    }
}
