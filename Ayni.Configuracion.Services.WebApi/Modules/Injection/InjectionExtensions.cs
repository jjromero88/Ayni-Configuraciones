using AutoMapper;
using Ayni.Configuracion.Transversal.Mapper;
using Ayni.Configuracion.Transversal.Common;
using Ayni.Configuracion.Infraestructure.Data;
using Ayni.Configuracion.Infraestructure.Repository;
using Ayni.Configuracion.Infraestructure.Interface;
using Ayni.Configuracion.Domain.Interface;
using Ayni.Configuracion.Domain.Core;
using Ayni.Configuracion.Aplication.Interface;
using Ayni.Configuracion.Aplication.Main;

namespace Ayni.Configuracion.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IMonedaApplication, MonedaApplication>();
            services.AddScoped<IMonedaDomain, MonedaDomain>();
            services.AddScoped<IMonedaRepository, MonedaRepository>();
           
            //services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}
