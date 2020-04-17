using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomeModelBinderInMVC.Startup))]
namespace CustomeModelBinderInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
