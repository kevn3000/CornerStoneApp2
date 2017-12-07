using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CornerStoneApp2.Startup))]
namespace CornerStoneApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
