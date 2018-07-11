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

        public QueryDTO GetQueryResult(double price, string type)
        {
            if(type is null)
            {
                return new QueryDTO
                {
                    Result = "fail",
                };
            }

            if (type.ToLower().Equals("lower"))
            {
                return new QueryDTO
                {
                    Result = "ok",
                    Clothes = warehouseRepo.Read().Where(w => w.UnitPrice < price).ToList()
                };
            }
            else if (type.ToLower().Equals("higher"))
            {
                return new QueryDTO
                {
                    Result = "ok",
                    Clothes = warehouseRepo.Read().Where(w => w.UnitPrice > price).ToList()
                };
            }
            else if (type.ToLower().Equals("equal"))
            {
                return new QueryDTO
                {
                    Result = "ok",
                    Clothes = warehouseRepo.Read().Where(w => w.UnitPrice == price).ToList()
                };
            }
            else
            {
                return new QueryDTO
                {
                    Result = "fail",
                };
            }
        }

        public TotalPriceDTO GetTotalPriceOfWare(Warehouse ware, int amount)
        {
            Warehouse selected = warehouseRepo.Read().FirstOrDefault(w => w.ItemName.Equals(ware.ItemName) &&
                                                                          w.Size.Equals(ware.Size));

            double totalPrice = (double)selected.UnitPrice * amount;

            return new TotalPriceDTO
            {
                Amount = amount,
                TotalPrice = totalPrice,
                Ware = selected
            };
        }
    }
}
