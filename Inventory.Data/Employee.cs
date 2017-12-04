using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class Employee
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Key]
        public int IdNumber { get; set; }

        [Required]
        public string UserName { get; set; } //foreign key

        [Required]
        public string Password { get; set; }
    }
}
