using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BasicCRUD.Models
{
    public class EmploymentRole
    {
        public string Designation { get; set; }
        public string EmploymentAssignment { get; set; }
        public double BasicSalary { get; set; }
    }
}