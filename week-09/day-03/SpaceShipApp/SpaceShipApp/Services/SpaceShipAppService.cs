using SpaceShipApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.Services
{
    public class SpaceShipAppService : IService
    {
        private SpaceshipRepository spaceShipRepo;
        private PlanetRepository planetRepo;

        public SpaceShipAppService(SpaceshipRepository spaceShipRepo, PlanetRepository planetRepo)
        {
            this.spaceShipRepo = spaceShipRepo;
            this.planetRepo = planetRepo;
        }


    }
}
