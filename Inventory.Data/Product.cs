using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class Product
    {
        public bool IsFlagged { get; set; }

        [Key]
        public string Number { get; set; } //item numbers include both letters & numbers

        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Location { get; set; } //locations can include combination of letters and numbers

        public string Comments { get; set; }

        [Required]
        public string UserName { get; set; } //foreign key
    }
}
