using Microsoft.Extensions.DependencyInjection;
using NSE.Pagamentos.Data;
using NSE.Pagamentos.Data.Repository;
using NSE.Pagamentos.Models;

namespace NSE.Pagamentos.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}
