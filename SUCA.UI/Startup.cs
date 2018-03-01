using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SUCA.UI.Startup))]
namespace SUCA.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
