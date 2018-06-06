using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspProj.Startup))]
namespace AspProj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
