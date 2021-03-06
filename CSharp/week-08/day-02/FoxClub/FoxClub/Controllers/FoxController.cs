﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("[controller]")]
    public class FoxController : Controller
    {
        IFox foxClub;

        public FoxController(IFox foxClub)
        {
            this.foxClub = foxClub;
        }

        [HttpGet("NutritionStore")]
        public IActionResult NutritionStore()
        {
            if (foxClub.GetName() == null)
            {
                return RedirectToAction("login", "Home", new { area = "" });
            }

            return View();
        }

        [HttpPost("NutritionStore")]
        public IActionResult GetNutrition(string food, string drink)
        {
            foxClub.SetDrink(drink);
            foxClub.SetFood(food);

            return RedirectToAction("Index", "Home", new { area =""});
        }

        [HttpGet("TrickCenter")]
        public IActionResult TrickCenter()
        {
            if (foxClub.GetName() == null)
            {
                return RedirectToAction("login", "Home", new { area = "" });
            }

            return View(foxClub);
        }

        [HttpPost("TrickCenter")]
        public IActionResult GetTrick(string trick)
        {
            foxClub.SetTricks(trick);

            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpGet("ActionHistory")]
        public IActionResult ActionHistory()
        {
            if (foxClub.GetName() == null)
            {
                return RedirectToAction("login", "Home", new { area = "" });
            }

            return View(foxClub);
        }
    }
}