using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Roles
    {
        public Roles()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleNote { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
