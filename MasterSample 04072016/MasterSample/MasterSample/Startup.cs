using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterSample.Startup))]
namespace MasterSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
