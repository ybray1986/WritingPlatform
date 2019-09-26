using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WritingPlatform.WEB.Startup))]
namespace WritingPlatform.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
