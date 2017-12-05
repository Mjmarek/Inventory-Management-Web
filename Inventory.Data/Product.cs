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
        [Display(Name = "Follow Up")]
        public bool IsFlagged { get; set; }

        [Display(Name = "Item Number")]
        public string Number { get; set; }

        [Display(Name = "Item Name")]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Location { get; set; }

        public string Comments { get; set; }

        [Display(Name="Manager")]
        public string UserName { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
