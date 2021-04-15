using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitMVC.Startup))]
namespace gitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
