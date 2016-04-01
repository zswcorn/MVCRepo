using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPlugins.Startup))]
namespace WebAppPlugins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
