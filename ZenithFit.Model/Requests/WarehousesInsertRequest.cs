using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class WarehousesInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string WarehouseName { get; set; }
        [Required]
        [MinLength(4)]
        public string WarehouseAddress { get; set; }
        public string WarehouseNote { get; set; }
    }
}
