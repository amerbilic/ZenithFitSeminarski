using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class RequestDetails
    {
        public int RequestDetailsId { get; set; }
        public string RequestResponse { get; set; }
        public int RequestId { get; set; }
        public int UserId { get; set; }

        public virtual Requests Request { get; set; }
        public virtual Users User { get; set; }
    }
}
