using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalAccounting.Startup))]
namespace PersonalAccounting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
