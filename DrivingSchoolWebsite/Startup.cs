using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrivingSchoolWebsite.Startup))]
namespace DrivingSchoolWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
