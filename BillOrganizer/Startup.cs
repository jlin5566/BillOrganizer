using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillOrganizer.Startup))]
namespace BillOrganizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
