using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Requests
    {
        public Requests()
        {
            RequestDetails = new HashSet<RequestDetails>();
        }

        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestTitle { get; set; }
        public string RequestDescription { get; set; }
        public int ClientId { get; set; }

        public virtual Clients Client { get; set; }
        public virtual ICollection<RequestDetails> RequestDetails { get; set; }
    }
}
