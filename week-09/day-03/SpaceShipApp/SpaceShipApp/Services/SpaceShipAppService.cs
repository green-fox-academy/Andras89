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

        public void MovePeopleToPlanet(int id)
        {
            Planet currentPlanet = planetRepo.Read().FirstOrDefault(p => p.Id.Equals(id));
            Spaceship loadShip = spaceShipRepo.Read().First();

            currentPlanet.Population += loadShip.Utilization;
            loadShip.Utilization = 0;

            spaceShipRepo.Update(loadShip);
            planetRepo.Update(currentPlanet);
        }

        public void MovePeopleToShip(int id)
        {
            Planet currentPlanet = planetRepo.Read().FirstOrDefault(p => p.Id.Equals(id));
            Spaceship loadShip = spaceShipRepo.Read().First();

            int placesLeft = loadShip.MaxCapacity - loadShip.Utilization;

            if (placesLeft > 0 || currentPlanet.Population < 1)
            {
                
                if (currentPlanet.Population >= placesLeft)
                {
                    loadShip.Utilization += placesLeft;
                    currentPlanet.Population -= placesLeft;
                }
                else if(currentPlanet.Population < placesLeft)
                {
                    loadShip.Utilization += (int)currentPlanet.Population;
                    currentPlanet.Population = 0;
                }
            }

            spaceShipRepo.Update(loadShip);
            planetRepo.Update(currentPlanet);
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
