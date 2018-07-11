using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;
using WarehouseApp.Repositories;

namespace WarehouseApp.Services
{
    public class WarehouseService : IService
    {
        WarehouseRepository warehouseRepo;

        public WarehouseService(WarehouseRepository warehouseRepo)
        {
            this.warehouseRepo = warehouseRepo;
        }

        public List<Warehouse> GetAllCloths()
        {
            return warehouseRepo.Read();
        }

        public void GetTotalPriceOfWare(Warehouse ware, int amount)
        {
            Warehouse selected = warehouseRepo.Read().FirstOrDefault(w => w.ItemName.Equals(ware.ItemName) &&
                                                                          w.Size.Equals(ware.Size));


        }
    }
}
