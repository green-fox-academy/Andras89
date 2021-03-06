﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceShipApp.Services;

namespace SpaceShipApp.Controllers
{
    [Route("")]
    public class SpaceShipController : Controller
    {
        private IService spaceService;

        public SpaceShipController(IService spaceService)
        {
            this.spaceService = spaceService;
        }

        [HttpGet("")]
        public IActionResult SpaceTable()
        {
            return View(spaceService.GetAllSpaceEntities());
        }

        [HttpPost("movehere/{id}")]
        public IActionResult Movehere(int id)
        {
            spaceService.MoveSpaceShipToPlanetById(id);

            return RedirectToAction("SpaceTable");
        }

        [HttpGet("/toship/{id}")]
        public IActionResult PeopleToShip(int id)
        {
            spaceService.MovePeopleToShip(id);

            return RedirectToAction("SpaceTable");
        }

        [HttpGet("/toplanet/{id}")]
        public IActionResult PeopleToPlanet(int id)
        {
            spaceService.MovePeopleToPlanet(id);

            return RedirectToAction("SpaceTable");
        }
    }
}