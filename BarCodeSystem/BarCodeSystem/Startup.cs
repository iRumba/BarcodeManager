using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarCodeSystem.Startup))]
namespace BarCodeSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
