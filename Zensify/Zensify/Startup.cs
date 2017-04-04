using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zensify.Startup))]
namespace Zensify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
