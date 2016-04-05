using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppPlugins
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var Route = routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ValidatePlugins", action = "TestView", id = UrlParameter.Optional },
                //defaults: new { controller = "ValidatePlugins", action = "TestView", area = "Plugins", id = UrlParameter.Optional },
                namespaces: new string[] { "WebAppPlugins.Areas.Plugins.Controllers" }
                //namespaces: new string[] { "WebAppPlugins" }
            );
            //Route.DataTokens["area"] = "Plugins";
        }
    }
}
