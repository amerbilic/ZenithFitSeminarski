using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Manufacturers
    {
        public Manufacturers()
        {
            Articles = new HashSet<Articles>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
