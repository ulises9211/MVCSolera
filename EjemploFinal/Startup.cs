using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploFinal.Startup))]
namespace EjemploFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
