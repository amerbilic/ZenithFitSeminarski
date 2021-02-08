using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class WarehousesInsertRequest
    {
        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }
        public string WarehouseNote { get; set; }
    }
}
