using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebappfromGITHub.Startup))]
namespace WebappfromGITHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
