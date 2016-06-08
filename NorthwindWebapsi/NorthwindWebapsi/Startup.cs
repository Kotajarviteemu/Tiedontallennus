using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindWebapsi.Startup))]
namespace NorthwindWebapsi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
