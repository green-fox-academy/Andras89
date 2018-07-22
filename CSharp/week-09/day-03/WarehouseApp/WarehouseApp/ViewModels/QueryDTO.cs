using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;

namespace WarehouseApp.ViewModels
{
    public class QueryDTO
    {
        public string Result { get; set; }
        public List<Warehouse> Clothes { get; set; }
    }
}
