﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSE.Carrinho.Services;
using NSE.Core.Utils;
using NSE.MessageBus;

namespace NSE.Carrinho.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GettMessageQueueConnection("MessageBus"))
                .AddHostedService<CarrinhoIntegrationHandler>();

        }
    }
}
