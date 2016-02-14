using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerce.UI.Startup))]
namespace eCommerce.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
           ConfigureAuth(app);
        }
    }
}
