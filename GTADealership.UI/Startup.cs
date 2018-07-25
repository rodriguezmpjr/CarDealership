using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GTADealership.UI.Startup))]
namespace GTADealership.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
