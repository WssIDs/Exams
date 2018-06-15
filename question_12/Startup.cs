using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(question_12.Startup))]
namespace question_12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
