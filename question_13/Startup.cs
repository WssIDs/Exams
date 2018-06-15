using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(question_13.Startup))]
namespace question_13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
