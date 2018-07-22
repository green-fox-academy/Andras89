using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Controllers
{
    [Produces("application/json")]
    [Route("api/Guardian")]
    public class GuardianController : Controller
    {
        [HttpGet("groot")]
        public IActionResult Groot([FromQuery]string message)
        {
            if(message is null)
            {
                return Json(new { error = "I am Groot!" });
            }
            else
            {
                return Json(new { received = message, translated = "I am Groot!" });
            }
        }

        [HttpGet("yondu")]
        public IActionResult Arrow([FromQuery]double distance, [FromQuery] double time)
        {
            return Json(new {
                                distance = distance,
                                time = time,
                                speed = distance / time
                            });
        }
    }
}