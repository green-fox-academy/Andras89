using SpaceShipApp.Models;
using SpaceShipApp.Repositories;
using SpaceShipApp.ViewModels;
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

        public SpaceEntityDto GetAllSpaceEntities()
        {
            return new SpaceEntityDto
            {
                Planets = planetRepo.Read(),
                Spaceship = spaceShipRepo.Read()[0]
            };
        }

        public void MoveSpaceShipToPlanetById(int id)
        {
            string planetName = planetRepo.Read().FirstOrDefault(p => p.Id == id).Name;

            Spaceship shipAtNewLoc = spaceShipRepo.Read().First();

            shipAtNewLoc.Planet = planetName;

            spaceShipRepo.Update(shipAtNewLoc);
        }
    }
}
