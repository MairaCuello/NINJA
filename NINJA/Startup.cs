using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NINJA.Startup))]
namespace NINJA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
