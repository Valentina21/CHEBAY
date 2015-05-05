using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheBay.Areas.Shop.Controllers
{
    public class BuyController : Controller
    {
        // GET: Shop/Buy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy()
        {
            ViewBag.Message = "Buy page.";

            return View();
        }
    }
}