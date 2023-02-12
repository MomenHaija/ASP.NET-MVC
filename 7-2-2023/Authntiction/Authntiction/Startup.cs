using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authntiction.Startup))]
namespace Authntiction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
