using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalBlog.Startup))]
namespace FinalBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
