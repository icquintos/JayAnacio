using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BasicCRUD.Models
{
    public class UserAccounts
    {

        [Key]
        public int UserId { get; set; }

        [EmailAddress(ErrorMessage ="Please enter a valid email.")]
        [Required(ErrorMessage ="Email address is required.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password did not match.")]
        public string ConfirmPassword { get; set; }

        public List<Employee> Employee { get; set; }
    }
}