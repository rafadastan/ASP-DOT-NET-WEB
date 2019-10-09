using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProjectCrud.Startup))]
namespace MyProjectCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
