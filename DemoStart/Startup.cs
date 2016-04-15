using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoStart.Startup))]
namespace DemoStart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
