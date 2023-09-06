using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVCApp.Models
{
    //For font-end interface model
    public class EmployeeModel
    {
        //Data anotation allows use modify our models
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid EmployeeId.")]
        public int EmployeeId { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your fist name.")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your last name.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give us your Email Adress.")]
        public string EmailAdress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAdress", ErrorMessage = "The Email and Confirm Email must match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must hae a password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You need to provide a stronger password.")]
        public string Password { get; set; }


        [Display(Name = "Confrim Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your Password and confirm password do not match.")]
        public string ConfrimPassword { get; set; }
    }
}