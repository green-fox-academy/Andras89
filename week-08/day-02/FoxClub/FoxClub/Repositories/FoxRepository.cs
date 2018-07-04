using FoxClub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Repositories
{
    public class FoxRepository : IFoxRepository
    {
        FoxDbContext database;

        public FoxRepository(FoxDbContext database)
        {
            this.database = database;
        }

        public void Create(Fox fox)
        {
            database.Add(fox);
            database.SaveChanges();
        }

        public void Delete(Fox fox)
        {
            database.Remove(fox);
            database.SaveChanges();
        }

        public Fox Read(long id)
        {
            var output = database.Foxes.ToList().FirstOrDefault(f => f.Id == id);
            return output;
        }

        public void Update(Fox fox)
        {
            throw new NotImplementedException();
        }
    }
}
