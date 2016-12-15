using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAdmin.Startup))]
namespace MVCAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
