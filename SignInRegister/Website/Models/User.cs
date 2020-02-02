using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public long Number { get; set; }
        public UserType Type { get; set; }
    }


    public enum UserType
    {
        Parent,
        Teacher,
        Caregiver,
        Contractor
    }
}

