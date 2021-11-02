using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NhatKyGiangDay.Startup))]
namespace NhatKyGiangDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
