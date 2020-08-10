using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversitySystemGreyHat.Startup))]
namespace UniversitySystemGreyHat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
