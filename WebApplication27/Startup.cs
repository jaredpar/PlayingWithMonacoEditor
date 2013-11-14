using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication27.Startup))]
namespace WebApplication27
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
