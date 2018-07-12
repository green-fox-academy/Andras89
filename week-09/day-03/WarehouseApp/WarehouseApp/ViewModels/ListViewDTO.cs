using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Models;

namespace WarehouseApp.ViewModels
{
    public class ListViewDTO
    {
        public List<Warehouse> Wares { get; set; }
        public List<string> ItemNameGroup { get; set; }
        public List<string> ItemSizeGroup { get; set; }
    }
}
