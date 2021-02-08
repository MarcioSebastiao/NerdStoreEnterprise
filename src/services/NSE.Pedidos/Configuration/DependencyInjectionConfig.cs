using Microsoft.Extensions.DependencyInjection;
using NSE.Core.Mediator;
using NSE.Pedidos.Application.Queries;
using NSE.Pedidos.Domain.Pedidos;
using NSE.Pedidos.Domain.Vouchers;
using NSE.Pedidos.Infra.Data;
using NSE.Pedidos.Infra.Data.Repositories;

namespace NSE.Pedidos.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            services.AddScoped<IVoucherQueries, VoucherQueries>();

            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<IPedidoRepository, PedidoRespository>();
            services.AddScoped<PedidosContext>();
        }
    }
}
