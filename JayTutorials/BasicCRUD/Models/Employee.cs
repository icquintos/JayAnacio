using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BasicCRUD.Models
{
    public class Employee : Person
    {
        [Key]
        public int EmployeeNumber { get; set; }

        public EmploymentStatus Status { get; set; }

        public List<UserAccounts> UserAccounts { get; set; }

    }
}