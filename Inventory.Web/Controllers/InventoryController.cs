using Inventory.Contracts;
using Inventory.Data;
using Inventory.Models;
using Inventory.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Web.Controllers
{
    [Authorize]
    public class InventoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private readonly Lazy<IProduct> _productService;
        private IProduct ProductService => _productService.Value;

        public InventoryController()
        {
            _productService = new Lazy<IProduct>(() => new ProductService(Guid.Parse(User.Identity.GetUserId())));
        }

        //For Testing
        public InventoryController(Lazy<IProduct> productService)
        {
            _productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var model = _productService.Value.GetProductList();
            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (ProductService.CreateProduct(model))
            {
                TempData["SaveResult"] = "Your item was added to the list.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your item could not be added at this time.");
            return View(model);
        }

        // GET Product/Edit/id
        public ActionResult Edit(int id)
        {
            var detail = ProductService.GetProductById(id);
            var model =
                new ProductEditModel
                {
                    ProductId = detail.ProductId,
                    Flag = detail.Flag,
                    Number = detail.Number,
                    Name = detail.Name,
                    Quantity = detail.Quantity,
                    Location = detail.Location,
                    Comments = detail.Comments
                };

            return View(model);
        }

        // POST Product/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductEditModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.ProductId != id)
            {
                ModelState.AddModelError("", "The item Id did not match.");
                return View(model);
            }

            if (ProductService.EditProduct(model))
            {
                TempData["SaveResult"] = "The item was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your item could not be updated.");
            return View(model);
        }

        // GET: Product/Details/id
        public ActionResult Details(int id)
        {
            var model = ProductService.GetProductById(id);
            return View(model);
        }

        // GET: Product/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            ProductService.DeleteProduct(id);

            TempData["SaveResult"] = "The item was deleted.";

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}