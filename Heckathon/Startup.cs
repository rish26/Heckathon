using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Heckathon.Startup))]
namespace Heckathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
