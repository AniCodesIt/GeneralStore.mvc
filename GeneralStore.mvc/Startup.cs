using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralStore.mvc.Startup))]
namespace GeneralStore.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
