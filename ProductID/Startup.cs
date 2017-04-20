using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductID.Startup))]
namespace ProductID
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
