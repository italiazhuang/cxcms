using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cxcms.Startup))]
namespace cxcms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
