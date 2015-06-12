using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularSmartTableGrouping.Startup))]
namespace AngularSmartTableGrouping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
