using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class CreateEmployee
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "Please enter your login name.")]
        [Display(Name = "Login Name")]
        public string UserName { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Please create a password that has at least 4 characters.")]
        public string Password { get; set; }
    }
}
