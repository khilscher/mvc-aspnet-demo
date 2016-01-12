using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_aspnet.Startup))]
namespace mvc_aspnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
