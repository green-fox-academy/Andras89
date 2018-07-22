using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;

namespace WarehouseApp.Repositories
{
    public class WarehouseRepository : IGenericRepository<Warehouse>
    {
        GreenFoxWarehouseContext databaseContext;

        public WarehouseRepository(GreenFoxWarehouseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void Create(Warehouse element)
        {
            databaseContext.Warehouse.Add(element);
            databaseContext.SaveChanges();
        }

        public void Delete(Warehouse element)
        {
            databaseContext.Warehouse.Remove(element);
            databaseContext.SaveChanges();
        }

        public List<Warehouse> Read()
        {
            return databaseContext.Warehouse.ToList();
        }

        public void Update(Warehouse element)
        {
            databaseContext.Warehouse.Update(element);
            databaseContext.SaveChanges();
        }
    }
}
