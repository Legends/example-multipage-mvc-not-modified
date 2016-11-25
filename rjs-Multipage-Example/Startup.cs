using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rjs_Multipage_Example.Startup))]
namespace rjs_Multipage_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
