using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Repositories
{
    public class FoxRepository : IFoxRepository
    {
        DbContext database;

        public FoxRepository(DbContext database)
        {
            this.database = database;
        }
    }
}
