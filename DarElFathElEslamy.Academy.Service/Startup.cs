using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DarElFathElEslamy.Academy.Service.Startup))]
namespace DarElFathElEslamy.Academy.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
