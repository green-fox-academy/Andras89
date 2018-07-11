using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
