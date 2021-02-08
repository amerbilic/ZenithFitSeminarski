using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public partial class UserRoles
    {
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public DateTime ChangedDate { get; set; }
        public Users User { get; set; }
        public Roles Role { get; set; }
    }
}
