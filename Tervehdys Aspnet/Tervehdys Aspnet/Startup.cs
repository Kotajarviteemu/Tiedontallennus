using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tervehdys_Aspnet.Startup))]
namespace Tervehdys_Aspnet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
