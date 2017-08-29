using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay.Db.Entities
{
    public class Employee
    {
        [Key]
        public long EmployeeId { get; set; }

        [Required, MaxLength(20)]
        public string Firstname { get; set; }

        [Required, MaxLength(20)]
        public string Middlename { get; set; }

        [Required, MaxLength(20)]
        public string Lastname { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        public int Age { get; set; }

        public DateTime? DateOfHire { get; set; }

        public ICollection<EmploymentStatus> EmploymentStatus { get; set; }

        public Employee()
        {
            EmploymentStatus = new List<EmploymentStatus>();
        }
    }
}
