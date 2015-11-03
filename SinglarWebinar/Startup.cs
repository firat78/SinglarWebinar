using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinglarWebinar.Startup))]
namespace SinglarWebinar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
