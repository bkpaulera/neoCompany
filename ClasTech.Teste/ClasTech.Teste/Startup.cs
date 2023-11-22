using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClasTech.Teste.Startup))]
namespace ClasTech.Teste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
