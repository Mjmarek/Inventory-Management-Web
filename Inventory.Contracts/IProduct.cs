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
        bool CreateProduct(ProductCreateModel model);
        IEnumerable<ProductListModel> GetProductList();
        ProductDetailsModel GetProductById(int ProductId);
        bool EditProduct(ProductEditModel model);
        bool DeleteProduct(int ProductId);
    }
}
