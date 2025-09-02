using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wyebankwebsite.Startup))]
namespace wyebankwebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
