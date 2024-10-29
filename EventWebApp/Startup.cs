using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventWebApp.Startup))]
namespace EventWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
