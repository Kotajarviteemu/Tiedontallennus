using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTervehdys.Startup))]
namespace MvcTervehdys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
