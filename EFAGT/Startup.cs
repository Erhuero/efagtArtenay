using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFAGT.Startup))]
namespace EFAGT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
