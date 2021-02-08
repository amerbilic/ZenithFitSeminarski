using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class UsersSearchRequest
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public bool RolesLoadingEnabled { get; set; }
    }
}
