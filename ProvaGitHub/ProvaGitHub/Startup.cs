using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaGitHub.Startup))]
namespace ProvaGitHub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
