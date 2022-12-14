using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sante.Models.ViewModels
{
    public class RegisterViewModel
    {
         
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }


    }
}
    

