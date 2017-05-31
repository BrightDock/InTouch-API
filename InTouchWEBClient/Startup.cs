using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InTouchWEBClient.Startup))]
namespace InTouchWEBClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
