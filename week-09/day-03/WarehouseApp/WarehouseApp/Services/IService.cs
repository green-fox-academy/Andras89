using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;
using WarehouseApp.ViewModels;

namespace WarehouseApp.Services
{
    public interface IService
    {
        List<Warehouse> GetAllCloths();
        TotalPriceDTO GetTotalPriceOfWare(Warehouse ware, int amount);
        QueryDTO GetQueryResult(double price, string type);
    }
}
