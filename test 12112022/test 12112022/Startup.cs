using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_12112022.Startup))]
namespace test_12112022
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
