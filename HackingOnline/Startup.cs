using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackingOnline.Startup))]
namespace HackingOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
