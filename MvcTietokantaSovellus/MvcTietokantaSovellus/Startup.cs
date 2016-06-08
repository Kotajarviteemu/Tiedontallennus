using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTietokantaSovellus.Startup))]
namespace MvcTietokantaSovellus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
