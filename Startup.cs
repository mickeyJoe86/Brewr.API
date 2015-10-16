using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brewr.Startup))]
namespace Brewr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
