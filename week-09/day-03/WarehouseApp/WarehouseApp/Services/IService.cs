using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;

namespace WarehouseApp.Services
{
    public interface IService
    {
        List<Warehouse> GetAllCloths();
    }
}
