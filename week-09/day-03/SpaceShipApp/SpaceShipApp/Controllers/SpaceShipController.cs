using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceShipApp.Services;

namespace SpaceShipApp.Controllers
{
    public class SpaceShipController : Controller
    {
        private IService spaceService;

        public SpaceShipController(IService spaceService)
        {
            this.spaceService = spaceService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}