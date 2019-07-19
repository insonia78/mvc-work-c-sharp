using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.Web.Ui.Startup))]
namespace MyShop.Web.Ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
