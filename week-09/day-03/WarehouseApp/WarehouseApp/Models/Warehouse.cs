using System;
using System.Collections.Generic;

namespace WarehouseApp.Models
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public double? UnitPrice { get; set; }
    }
}
