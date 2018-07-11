using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;
using WarehouseApp.Repositories;
using WarehouseApp.ViewModels;

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

        public TotalPriceDTO GetTotalPriceOfWare(Warehouse ware, int amount)
        {
            Warehouse selected = warehouseRepo.Read().FirstOrDefault(w => w.ItemName.Equals(ware.ItemName) &&
                                                                          w.Size.Equals(ware.Size));

            int totalPrice = (int)selected.UnitPrice * amount;

            return new TotalPriceDTO
            {
                Amount = amount,
                TotalPrice = totalPrice,
                Ware = selected
            };
        }
    }
}
