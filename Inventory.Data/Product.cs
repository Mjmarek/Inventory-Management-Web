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
        [Key]
        public int ProductId { get; set; }

        public int? Flag { get; set; }

        public enum FlagColor
        {
            //green rgb(0, 153, 0) #009900 hue 120,
            //red rgb(255, 0, 0) #ff0000 hue 0,
            //yellow rgb(255, 255, 0) #ffff00 hue 60
        }

        [Required]
        public string Number { get; set; }

        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Location { get; set; }

        public string Comments { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
