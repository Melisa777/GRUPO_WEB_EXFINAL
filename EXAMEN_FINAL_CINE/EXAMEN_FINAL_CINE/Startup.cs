using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EXAMEN_FINAL_CINE.Startup))]
namespace EXAMEN_FINAL_CINE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
