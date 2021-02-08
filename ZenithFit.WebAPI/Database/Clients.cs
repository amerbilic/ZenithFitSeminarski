using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Clients
    {
        public Clients()
        {
            CompleteOrder = new HashSet<CompleteOrder>();
            Orders = new HashSet<Orders>();
            Ratings = new HashSet<Ratings>();
            Requests = new HashSet<Requests>();
        }

        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public DateTime ClientRegisterDate { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhone { get; set; }
        public string ClientUsername { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<CompleteOrder> CompleteOrder { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
