using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubFirstProj.Startup))]
namespace GitHubFirstProj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
