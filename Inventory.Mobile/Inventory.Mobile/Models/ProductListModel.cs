using Inventory.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Mobile
{
    public class ProductListModel
    {
        public int ProductId { get; set; }

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

        public string Number { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Location { get; set; }

        public string Comments { get; set; }

        public string UserName { get; set; }
    }
}
