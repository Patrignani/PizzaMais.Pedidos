﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace PizzaMais.Produto.Core.Middleware
{
    public static class IOC
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(_ => new NpgsqlConnection(configuration.GetConnectionString("PizzaMais")));
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped<IFornecedorService, FornecedorService>();
            //services.AddScoped<IProdutoRevendaService, ProdutoRevendaService>();

            return services;
        }
    }
}
