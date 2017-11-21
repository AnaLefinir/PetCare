using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetCareApp.Startup))]
namespace PetCareApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
