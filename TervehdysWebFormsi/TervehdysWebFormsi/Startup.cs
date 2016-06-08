using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TervehdysWebFormsi.Startup))]
namespace TervehdysWebFormsi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
