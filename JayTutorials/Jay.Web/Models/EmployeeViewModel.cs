using Jay.Db.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jay.Web.Models
{
    public class AddEmployeeViewModel
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Middlename { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Gender { get; set; }

        public DateTime Birthdate { get; set; }

        [Required]
        public string Designation { get; set; }

        public double Salary { get; set; }

        public string EmploymentAssignment { get; set; }
        
        private int _age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Birthdate.Year;

                return Birthdate > today.AddYears(-age)
                    ? age - 1
                    : age;
            }
        }

        public Employee ParseToDataModel()
        {
            var employee = new Employee()
            {
                Firstname = this.Firstname,
                Middlename = this.Middlename,
                Lastname = this.Lastname,
                Gender = this.Gender,
                Birthdate = this.Birthdate,
                Age = this._age,
                DateOfHire = DateTime.Now
            };

            var status = new EmploymentStatus()
            {
                Designation = this.Designation,
                BasicSalary = this.Salary,
                EmploymentAssignment = this.EmploymentAssignment
            };

            employee.EmploymentStatus.Add(status);

            return employee;
        }   
    }
}