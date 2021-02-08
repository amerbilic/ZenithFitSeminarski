using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ManufacturersInsertRequest
    {
        [Required]
        public string ManufacturerName { get; set; }
    }
}
