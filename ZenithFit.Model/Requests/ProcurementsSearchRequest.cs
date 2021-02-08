using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ProcurementsSearchRequest
    {
        public DateTime ProcurementDate { get; set; }
        public string ProcurementNumber { get; set; }
    }
}
