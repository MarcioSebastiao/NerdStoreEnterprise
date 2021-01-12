using Microsoft.Extensions.DependencyInjection;
using NSE.Clientes.Data;
using NSE.Clientes.Data.Repository;
using NSE.Clientes.Models;

namespace NSE.Clientes.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}
