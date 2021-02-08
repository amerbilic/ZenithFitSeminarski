using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ClientsInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string ClientFirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientLastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime ClientRegisterDate { get; set; }

        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string ClientEmail { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientPhone { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientUsername { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PasswordConfirmation { get; set; }
    }
}
