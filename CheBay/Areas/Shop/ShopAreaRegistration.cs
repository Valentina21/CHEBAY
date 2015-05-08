using System.Web.Mvc;

namespace CheBay.Areas.Shop
{
    public class ShopAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Shop";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Shop_default",
                "{shop}/Shop/{controller}/{action}/{id}",
                new { shop = UrlParameter.Optional, action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}