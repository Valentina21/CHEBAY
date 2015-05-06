using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheBay.Areas.Administration.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Administration/Products
        public ActionResult Index()
        {
            return View();
        }
    }
}