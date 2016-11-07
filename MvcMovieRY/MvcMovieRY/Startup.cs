using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovieRY.Startup))]
namespace MvcMovieRY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
