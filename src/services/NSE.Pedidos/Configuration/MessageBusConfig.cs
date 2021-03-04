using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSE.Core.Utils;
using NSE.MessageBus;
using NSE.Pedidos.Services;

namespace NSE.Pedidos.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GettMessageQueueConnection("MessageBus"))
                .AddHostedService<PedidoOrquestradorIntegrationHandler>();
        }
    }
}
