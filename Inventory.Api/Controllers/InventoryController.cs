using Inventory.Models;
using Inventory.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inventory.Api.Controllers
{
    [Authorize]
    public class InventoryController : ApiController
    {
        public IHttpActionResult GetAllProducts()
        {
            var productService = new ProductService(User);
            var products = productService.GetProductList();

            return Ok(products);
        }

        public IHttpActionResult Get(int id)
        {
            var productService = new ProductService(User);
            var product = productService.GetProductById(id);

            if (product == null) return NotFound();

            return Ok(product);
        }

        public IHttpActionResult Post(ProductCreateModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var productService = new ProductService(User);

            return Ok(productService.CreateProduct(model));
        }

        public IHttpActionResult Put(ProductEditModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var productService = new ProductService(User);
            var temp = productService.GetProductById(model.ProductId);

            if (temp == null) return NotFound();

            return Ok(productService.EditProduct(model));
        }

        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var productService = new ProductService(User);
            var temp = productService.GetProductById(id);

            if (temp == null) return NotFound();

            return Ok(productService.DeleteProduct(id));
        }
    }
}
