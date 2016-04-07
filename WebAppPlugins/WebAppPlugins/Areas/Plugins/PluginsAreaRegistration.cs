using System.Web.Mvc;

namespace WebAppPlugins.Areas.Plugins
{
    public class PluginsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Plugins";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Plugins_default",
                "Plugins/{controller}/{action}/{id}",//"",
                //new { action = "TestView", id = UrlParameter.Optional }
                new { controller = "ValidatePlugins", action = "TestView", id = UrlParameter.Optional },
                new string[] { "WebAppPlugins.Areas.Plugins.Controllers" }
            );
        }
    }
}