using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vs_proj.Startup))]
namespace vs_proj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
