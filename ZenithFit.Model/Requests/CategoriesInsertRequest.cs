using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class CategoriesInsertRequest
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
