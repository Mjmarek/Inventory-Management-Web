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
        [Display(Name = "Item Number")]
        public string Number { get; set; }

        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Location { get; set; }

        public string Comments { get; set; }

        public override string ToString() => $"[{ProductId}] {Name}";
    }
}
