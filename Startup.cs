using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Redes_Sociales_4B.Startup))]
namespace Redes_Sociales_4B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
