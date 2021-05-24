using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;

namespace coin_conversion_API.configuration
{
    public static class ResolveSwaggerConfig
    {
        public static void ResolveSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "coin_conversion_API",
                    Description = "Aplicação para conversão de moedas.",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Lucas Santos",
                        Email = "lucaslima.devs@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/lucas-santos-gonçalves-lima-a05a95203")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                swagger.IncludeXmlComments(xmlPath);
            });
        }
    }
}
