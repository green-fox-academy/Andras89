using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyProjectApiReboot.Controllers
{
    [Produces("application/json")]
    [Route("MVC")]
    public class MVCController : Controller
    {
        [HttpGet]
        [Route("Hello")]
        public IActionResult Hello()
        {
            return Content("Hello this is the hello method!");
        }
    }
}