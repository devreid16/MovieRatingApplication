using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ARMasterLock.Startup))]
namespace ARMasterLock
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
