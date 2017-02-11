using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoSharingApp.Startup))]
namespace PhotoSharingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
