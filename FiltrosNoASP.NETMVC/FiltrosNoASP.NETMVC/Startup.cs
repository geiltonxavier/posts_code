using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FiltrosNoASP.NETMVC.Startup))]
namespace FiltrosNoASP.NETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
