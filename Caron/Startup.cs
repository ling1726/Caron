using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Caron.Startup))]
namespace Caron
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
