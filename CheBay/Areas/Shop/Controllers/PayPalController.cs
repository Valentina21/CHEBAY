using CheBay.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class PayPalController : Controller
    {
        public ActionResult ValidateCommand(string product, string totalPrice, int idRecursos, int cantidadRecurso)
        {
            bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
            var paypal = new PayPalModel(useSandbox);

            paypal.@return = "http://" + Request.Url.Host + ":" + Request.Url.Port + "/" + paypal.@return;
            paypal.cancel_return = "http://" + Request.Url.Host + ":" + Request.Url.Port + "/" + paypal.cancel_return;
            paypal.notify_url = "http://" + Request.Url.Host + ":" + Request.Url.Port + "/" + paypal.notify_url;

            paypal.item_name = product;
            paypal.amount = totalPrice;
            return View(paypal);
        }

        public ActionResult RedirectFromPaypal(dynamic d)
        {
            //En caso de que ocurra bien la venta.
            return View();
        }

        public ActionResult CancelFromPaypal(dynamic d)
        {
            //Caso en que no salga bien la venta.
            return View();
        }

        public ActionResult NotifyFromPaypal(dynamic d)
        {
            //Caso de recibir notificación desde PayPal.
            return View();
        }
    }
}