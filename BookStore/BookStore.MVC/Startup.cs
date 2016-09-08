using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore.MVC.Startup))]
namespace BookStore.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
