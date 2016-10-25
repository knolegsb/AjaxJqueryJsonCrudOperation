using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxJqueryJsonCRUDOperation.Startup))]
namespace AjaxJqueryJsonCRUDOperation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
