using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserUsername { get; set; }
        public int NumberOfOrders { get; set; }
        public List<UserRoles> UserRoles { get; set; }
    }
}
