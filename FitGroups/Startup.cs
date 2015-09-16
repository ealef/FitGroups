using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitGroups.Startup))]
namespace FitGroups
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
