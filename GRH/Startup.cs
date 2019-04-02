using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GRH.Startup))]
namespace GRH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
