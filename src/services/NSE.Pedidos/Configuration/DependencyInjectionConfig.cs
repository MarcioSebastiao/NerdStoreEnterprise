using Microsoft.Extensions.DependencyInjection;
using NSE.Core.Mediator;

namespace NSE.Pedidos.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
        }
    }
}
