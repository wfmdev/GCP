using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCP.Survey.Startup))]
namespace GCP.Survey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
