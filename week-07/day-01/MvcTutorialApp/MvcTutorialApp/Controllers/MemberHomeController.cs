using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcTutorialApp.Controllers
{
    [Route("[controller]")]
    public class MemberHomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Access")]
        public IActionResult AccessGranted()
        {
            return View();
        }
    }
}
