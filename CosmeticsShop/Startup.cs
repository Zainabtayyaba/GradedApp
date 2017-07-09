using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CosmeticsShop.Startup))]
namespace CosmeticsShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
