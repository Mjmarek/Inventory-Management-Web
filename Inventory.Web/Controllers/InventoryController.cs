using Inventory.Models;
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
            var model = new ProductListItem[0];
            return View(model);
        }
    }
}