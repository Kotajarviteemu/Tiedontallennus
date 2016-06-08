using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityTehtava.Startup))]
namespace EntityTehtava
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
