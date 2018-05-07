using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCSys.Startup))]
namespace NCSys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
