using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Services;

namespace WarehouseApp.Controllers
{
    [Route("")]
    public class WarehouseController : Controller
    {
        IService database;

        public WarehouseController(IService database)
        {
            this.database = database;
        }
    }
}