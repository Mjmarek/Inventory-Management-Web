using Inventory.Models;
using Inventory.Services;
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
        
        // GET: Inventory
        public ActionResult Index()
        {
            var model = new ProductListModel[0];
            return View(model);
        }
    }
}