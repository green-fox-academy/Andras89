using SpaceShipApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.Repositories
{
    public class SpaceshipRepository : IGenericRepository<Spaceship>
    {
        private SpaceShipDbContext dbContext;

        public SpaceshipRepository(SpaceShipDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Spaceship element)
        {
            dbContext.Spaceship.Add(element);
            dbContext.SaveChanges();
        }

        public void Delete(Spaceship element)
        {
            dbContext.Spaceship.Remove(element);
            dbContext.SaveChanges();
        }

        public List<Spaceship> Read()
        {
            return dbContext.Spaceship.ToList();
        }

        public void Update(Spaceship element)
        {
            dbContext.Spaceship.Update(element);
            dbContext.SaveChanges();
        }
    }
}
