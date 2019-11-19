using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantMvC.Startup))]
namespace RestaurantMvC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
