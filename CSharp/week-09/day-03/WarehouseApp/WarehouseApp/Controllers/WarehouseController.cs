﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Models;
using WarehouseApp.Services;
using WarehouseApp.ViewModels;

namespace WarehouseApp.Controllers
{
    [Produces("application/json")]
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
            return View(database.GetListViewElements());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult TotalResult(Warehouse ware, int amount)
        {
            TotalPriceDTO summary = database.GetTotalPriceOfWare(ware, amount);

            return View("Summary", summary);
        }

        [HttpGet("warehouse/summary/query")]
        public IActionResult QueryResult([FromQuery]double price, [FromQuery] string type)
        {
            QueryDTO query = database.GetQueryResult(price, type);

            return Json(query);
        }
    }
}