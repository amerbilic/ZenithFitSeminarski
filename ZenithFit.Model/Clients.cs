using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Clients
    {
        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public DateTime ClientRegisterDate { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhone { get; set; }
        public string ClientUsername { get; set; }
        public int NumberOfRatings { get; set; }
        public int NumberOfOrders { get; set; }
    }
}
