using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay.Db.Entities
{
    public class EmploymentStatus
    {
        [Key]
        public long EmploymentStatusId { get; set; }
        
        [Required]
        public string Designation { get; set; }

        public string EmploymentAssignment { get; set; }
        
        [Required]
        public double BasicSalary { get; set; }

        public Employee Employee { get; set; }
        public long EmployeeId { get; set; }
    }
}