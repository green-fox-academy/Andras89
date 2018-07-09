using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repository
{
    public class LoggerRepository : IGenericRepository<Logger>
    {
        private FrontendDbContext loggerDb;

        public LoggerRepository(FrontendDbContext loggerDb)
        {
            this.loggerDb = loggerDb;
        }

        public void Create(Logger element)
        {
            loggerDb.LoggerDb.Add(element);
            loggerDb.SaveChanges();
        }

        public List<Logger> Read()
        {
            return loggerDb.LoggerDb.ToList();
        }
    }
}
