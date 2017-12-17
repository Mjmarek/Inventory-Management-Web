using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ProductCreateModel
    {
        [Display(Name = "Follow Up")]
        public ProductAvailability? Flag { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Please enter the product's item number.")]
        [Display(Name = "Item Number")]
        public string Number { get; set; } //item numbers include both letters & numbers

        public string Name { get; set; }

        [Required]
        [Display(Name = "Quantity on Floor")]
        public int Quantity { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Please enter at least one location for the item.")]
        public string Location { get; set; } //locations can include combination of letters and numbers

        public string Comments { get; set; }
    }
}
