using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;

namespace WarehouseApp.ViewModels
{
    public class TotalPriceDTO
    {
        public Warehouse Ware { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
    }
}
