using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HarjoitusWeb.Startup))]
namespace HarjoitusWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
