using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mitrais_Test_DTO
{
    public class UserDTO
    {
        [Required]
        public string Phone { get; set; }
        public string Dob { get; set; }

        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
