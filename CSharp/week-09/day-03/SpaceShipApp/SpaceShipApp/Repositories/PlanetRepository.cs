using SpaceShipApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.Repositories
{
    public class PlanetRepository : IGenericRepository<Planet>
    {
        private SpaceShipDbContext dbContext;

        public PlanetRepository(SpaceShipDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Planet element)
        {
            dbContext.Planet.Add(element);
            dbContext.SaveChanges();
        }

        public void Delete(Planet element)
        {
            dbContext.Planet.Remove(element);
            dbContext.SaveChanges();
        }

        public List<Planet> Read()
        {
            return dbContext.Planet.ToList();
        }

        public void Update(Planet element)
        {
            dbContext.Planet.Update(element);
            dbContext.SaveChanges();
        }
    }
}
