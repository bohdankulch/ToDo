using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoTask.Startup))]
namespace ToDoTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
