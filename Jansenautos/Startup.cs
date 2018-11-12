using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jansenautos.Startup))]
namespace Jansenautos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
