using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Categories
    {
        public Categories()
        {
            Articles = new HashSet<Articles>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
