using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

 

 

namespace MVC_DataLayerStart.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(10, ErrorMessage = "Last NAME LENGTH SHOULD NOT BE GRATER THAN 10")]
        public string LastName { get; set; }




        [Range(10000, 30000)]
        public int? Salary { get; set; }
    }






    //Custom Validator





    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)//Checking for Empty Value
            {
                return new ValidationResult("Please provide First Name");





            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should not contatin @!");
                }
            }
            return ValidationResult.Success;





        }
    }
}