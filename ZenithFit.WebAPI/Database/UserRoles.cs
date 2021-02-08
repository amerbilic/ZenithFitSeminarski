using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class UserRoles
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime ChangeDate { get; set; }

        public virtual Roles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
