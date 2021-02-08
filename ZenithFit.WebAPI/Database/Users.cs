using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Users
    {
        public Users()
        {
            CompleteOrder = new HashSet<CompleteOrder>();
            Notices = new HashSet<Notices>();
            Orders = new HashSet<Orders>();
            Procurements = new HashSet<Procurements>();
            RequestDetails = new HashSet<RequestDetails>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserUsername { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<CompleteOrder> CompleteOrder { get; set; }
        public virtual ICollection<Notices> Notices { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Procurements> Procurements { get; set; }
        public virtual ICollection<RequestDetails> RequestDetails { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
