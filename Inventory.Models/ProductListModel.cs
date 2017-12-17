using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ProductListModel
    {
        public int ProductId { get; set; }
       
        [Display(Name = "Follow Up")]
        public ProductAvailability? Flag { get; set; }

        public string FlagColor => GetFlagColor();

        private string GetFlagColor()
        {
            switch (Flag)
            {
                case ProductAvailability.Available:
                    return "#009900";
                case ProductAvailability.OnOrder:
                    return "#ffcc00";
                case ProductAvailability.NotAvailable:
                    return "#ff0000";
                default:
                    return null;
            }
        }

        public string FlagCategory => GetFlagCategory();

        private string GetFlagCategory()
        {
            switch (Flag)
            {
                case ProductAvailability.Available:
                    return "Available";
                case ProductAvailability.OnOrder:
                    return "On Order";
                case ProductAvailability.NotAvailable:
                    return "Not Available";
                default:
                    return null;
            }
        }

        [Display(Name = "Item Number")]
        public string Number { get; set; } //item numbers include both letters & numbers

        public string Name { get; set; }

        [Display(Name = "Quantity on Floor")]
        public int Quantity { get; set; }

        public string Location { get; set; } //locations can include combination of letters and numbers

        public string Comments { get; set; }

        [Display(Name = "Manager")]
        public string UserName { get; set; }

        public override string ToString() => $"[{ProductId}] {Name}";//not sure if I need this
    }
}
