using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fix.Startup))]
namespace fix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
