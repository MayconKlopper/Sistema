using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema.Apresentacao.Startup))]
namespace Sistema.Apresentacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
