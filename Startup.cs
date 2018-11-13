using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokemonCS.Startup))]
namespace PokemonCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
