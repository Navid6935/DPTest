using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DPTest.Startup))]
namespace DPTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
