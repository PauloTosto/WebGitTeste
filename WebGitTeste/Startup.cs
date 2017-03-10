using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGitTeste.Startup))]
namespace WebGitTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
