using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Contracts
{
    public interface IProduct
    {
        bool CreateProduct(CreateProduct model);
        IEnumerable<ProductListItem> GetProducts();
        DetailsProduct GetProductById(int ProductId);//need to change type to int in table
        bool EditProduct(EditProduct model);
        bool DeleteProduct(int ProductId);
    }
}
