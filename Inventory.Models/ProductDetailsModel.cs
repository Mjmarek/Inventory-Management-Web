using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Inventory.Models
{
    public class ProductDetailsModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Follow Up")]
        public ProductAvailability? Flag { get; set; }
        public string AvailabilityName =>
            (FlagCategoryList.FirstOrDefault(sli => int.Parse(sli.Value) == (int?)Flag))?.Text;


        public IEnumerable<SelectListItem> FlagCategoryList => new List<SelectListItem>
        {
            new SelectListItem
            {
                Text = "Available",
                Value = ((int)ProductAvailability.Available).ToString()
            },

            new SelectListItem
            {
                Text = "On Order",
                Value = ((int)ProductAvailability.OnOrder).ToString()
            },

            new SelectListItem
            {
                Text = "Not Available",
                Value = ((int)ProductAvailability.NotAvailable).ToString()
            }
        };

        [Display(Name = "Item Number")]
        public string Number { get; set; }

        public string Name { get; set; }

        [Display(Name = "Quantity on Floor")]
        public int Quantity { get; set; }

        public string Location { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Manager")]
        public string UserName { get; set; }

        public override string ToString() => $"[{ProductId}] {Name}";
    }
}
