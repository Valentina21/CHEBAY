using System.Web.Mvc;

namespace CheBay.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administration_default",
                "{shop}/Administration/{controller}/{action}/{id}",
                new { shop = UrlParameter.Optional ,action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}