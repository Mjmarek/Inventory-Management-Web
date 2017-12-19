using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Mobile.Contracts
{
    interface IProductService
    {
        Task<bool> Login(string username, string password);

        Task<List<ProductListModel>> GetProductList();

        Task<ProductDetailsModel> GetProductById(int productId);

        Task<bool> CreateProduct(ProductCreateModel product);

        Task<bool> DeleteProduct(int productId);
    }
}