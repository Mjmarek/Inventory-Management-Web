using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ProductListItem
    {
        [Display(Name = "Follow Up")]
        public int Flag { get; set; }

        [Display(Name = "Item Number")]
        public string Number { get; set; } //item numbers include both letters & numbers

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Location { get; set; } //locations can include combination of letters and numbers

        public string Comments { get; set; }

        [Display(Name = "Manager")]
        public string UserName { get; set; } //foreign key
    }
}
