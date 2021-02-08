using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class UsersInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string UserFirstName { get; set; }
        [Required]
        [MinLength(4)]
        public string UserLastName { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        public string UserPhone { get; set; }
        [Required]
        [MinLength(4)]
        public string UserUsername { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }

        public List<int> Roles { get; set; } = new List<int>();
    }
}
