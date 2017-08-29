using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
    
namespace BasicCRUD.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required(ErrorMessage ="First name field is required. ")]
        public string Firstname { get; set; }

        [Required(ErrorMessage ="Middle name field is required. ")]
        public string Middlename { get; set; }

        [Required(ErrorMessage ="Last name field is required. ")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Gender field is requied")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Birthdate field is required")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public int Age
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

        
    }
}