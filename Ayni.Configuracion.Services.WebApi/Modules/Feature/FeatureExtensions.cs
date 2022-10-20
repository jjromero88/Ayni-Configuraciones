using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Ayni.Configuracion.Services.WebApi.Modules.Feature
{
    public static class FeatureExtensions
    {
        public static IServiceCollection AddFeature(this IServiceCollection services, IConfiguration configuration)
        {
            string myPolicy = "policyApiAyniConfiguracion";

            services.AddCors(options =>
                options.AddPolicy(myPolicy, builder => builder.WithOrigins(configuration["Config:OriginCors"])
                                                                                        .AllowAnyOrigin()
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()));
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Latest);

            return services;
        }
    }
}
