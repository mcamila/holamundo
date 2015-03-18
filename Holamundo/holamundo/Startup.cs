using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(holamundo.Startup))]
namespace holamundo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
