using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System.Configuration;

namespace CheBay.App_Start
{
    public partial class Startup
    {

        public void ConfigureAuth(IAppBuilder app)
        {
            // Permitir que la aplicación use una cookie para almacenar información para el usuario que inicia sesión
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Index")
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            //Local Express
            app.UseFacebookAuthentication(
               appId: "647546415347128",
               appSecret: "162f41793eacd92322c2c59804bf4829");

            //Local
            /*app.UseFacebookAuthentication(
               appId: "686189614777345",
               appSecret: "c017e26deea23f169fe5d2c3da46f61d");*/

            //Azure
            /*app.UseFacebookAuthentication(
               appId: "693759074020399",
               appSecret: "fa4749cf1eda2cdc6a201b13d76dc53e");*/

            //app.UseGoogleAuthentication();
        }
    }
}