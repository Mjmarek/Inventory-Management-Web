using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class CreateProduct
    {
        [Display(Name = "Follow Up")]
        public int Flag { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Please enter the product's item number.")]
        [Display(Name = "Item Number")]
        public string Number { get; set; } //item numbers include both letters & numbers

        [Required]
        [MinLength(5, ErrorMessage = "Please enter the name of the item.")]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Please enter at least one location for the item.")]
        public string Location { get; set; } //locations can include combination of letters and numbers

        public string Comments { get; set; }

        [Display(Name = "Manager")]
        [MaxLength(6, ErrorMessage = "Please enter your login name.")]
        public string UserName { get; set; }
    }
}
