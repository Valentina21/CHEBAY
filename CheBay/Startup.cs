using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using CheBay.App_Start;
using System.Configuration;

[assembly: OwinStartupAttribute(typeof(CheBay.App_Start.Startup))]
namespace CheBay.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
            
        }
    }
}