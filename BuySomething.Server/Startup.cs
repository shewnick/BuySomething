using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuySomething.Server.Startup))]
namespace BuySomething.Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
