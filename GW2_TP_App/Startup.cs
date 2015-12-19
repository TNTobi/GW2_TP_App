using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GW2_TP_App.Startup))]
namespace GW2_TP_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
