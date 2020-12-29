using Microsoft.Extensions.DependencyInjection;
using NSE.WebApp.Services;

namespace NSE.WebApp.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();
        }
    }
}
