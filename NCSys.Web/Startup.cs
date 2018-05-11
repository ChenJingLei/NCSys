using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCSys.Web.Startup))]
namespace NCSys.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
