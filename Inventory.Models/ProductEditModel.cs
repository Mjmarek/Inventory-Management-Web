using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ProductEditModel
    {
        [Required]
        public int ProductId { get; set; }

        [Display(Name = "Follow Up")]
        public int? Flag { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Please enter the product's item number.")]
        [Display(Name = "Item Number")]
        public string Number { get; set; }

        public string Name { get; set; }

        [Required]
        [Display(Name = "Quantity on Floor")]
        public int Quantity { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Please enter at least one location for the item.")]
        public string Location { get; set; }

        public string Comments { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please enter the name of the manager editing this item.")]
        [Display(Name = "Manager")]
        public string UserName { get; set; }

        public override string ToString() => $"[{ProductId}] {Name}";
    }
}
