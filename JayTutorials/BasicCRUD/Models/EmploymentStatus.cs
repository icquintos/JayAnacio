using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BasicCRUD.Models
{
    public class EmploymentStatus
    {
        public int YearOfService { get; set; }
        public DateTime? DateOfHire { get; set; }
        public EmploymentRole CurrentRole { get; set; }
        public List<EmploymentRole> RoleHistory { get; set; }
    }
}
