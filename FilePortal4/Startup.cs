using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilePortal4.Startup))]
namespace FilePortal4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
