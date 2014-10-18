using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QA_Forum.Startup))]
namespace QA_Forum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
