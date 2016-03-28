using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AconteceAngola.Web.Startup))]
namespace AconteceAngola.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
