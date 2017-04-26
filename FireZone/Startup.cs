using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FireZone.Startup))]
namespace FireZone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
