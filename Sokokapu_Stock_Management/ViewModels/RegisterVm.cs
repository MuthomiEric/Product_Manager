using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sokokapu_Stock_Management.ViewModels
{
    public class RegisterVm
    {
        [Required, Display(Name = "Email Address"), EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Display(Name = "Office Id")]
        public string OfficeId { get; set; }
        [Required, DataType(DataType.Password), MinLength(6), MaxLength(20)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), MinLength(6), MaxLength(20), Compare("Password", ErrorMessage = "Password does not match!!!"), Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
