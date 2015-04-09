using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetosTeste.Startup))]
namespace ProjetosTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
