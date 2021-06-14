using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoyalAirlines.Startup))]
namespace RoyalAirlines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
