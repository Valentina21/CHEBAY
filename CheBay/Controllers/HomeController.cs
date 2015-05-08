using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
namespace CheBay.Controllers
{
     public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index(int idTienda)
        {
            Session["idTienda"] = idTienda;
            return View();
        }
	}
 }



