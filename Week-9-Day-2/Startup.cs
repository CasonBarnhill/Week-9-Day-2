using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week_9_Day_2.Startup))]
namespace Week_9_Day_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
