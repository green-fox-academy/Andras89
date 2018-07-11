using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Services;

namespace WarehouseApp.Controllers
{
    [Route("shoppingplanner")]
    public class WarehouseController : Controller
    {
        IService database;

        public WarehouseController(IService database)
        {
            this.database = database;
        }

        [HttpGet("warehouse")]
        public IActionResult List()
        {
            return View(database.GetAllCloths());
        }

        [HttpPost("warehouse/summary")]
    }
}