using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PopcornTime_2._0.Startup))]
namespace PopcornTime_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
