﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSE.Catalogo.Services;
using NSE.Core.Utils;
using NSE.MessageBus;

namespace NSE.Catalogo.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GettMessageQueueConnection("MessageBus"))
                .AddHostedService<CatalogoIntegrationHandler>();
        }
    }
}
