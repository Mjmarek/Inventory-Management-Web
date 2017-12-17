using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public enum ProductAvailability
    {
        Available = 0, 
        OnOrder = 1,
        NotAvailable = 2
    }
}