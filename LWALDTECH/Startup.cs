using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LWALDTECH.Startup))]
namespace LWALDTECH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
