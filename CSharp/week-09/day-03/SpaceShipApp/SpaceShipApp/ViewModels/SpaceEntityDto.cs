using SpaceShipApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.ViewModels
{
    public class SpaceEntityDto
    {
        public List<Planet> Planets { get; set; }
        public Spaceship Spaceship { get; set; }
    }
}
