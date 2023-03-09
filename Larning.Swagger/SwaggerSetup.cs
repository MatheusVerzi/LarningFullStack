using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.IO;

namespace Larning.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            return services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Larning .Net Core",
                    Version = "v1",
                    Description = "TUtorial de desenvolvimento em .Net Core e Angular.",
                    Contact = new OpenApiContact
                    {
                        Name = "Matheus Reche Verzi",
                        Email = "verzi.matheus@gmail.com"
                    }

                });

                var xmlPath = Path.Combine("wwwroot", "api-doc.xml");
                options.IncludeXmlComments(xmlPath);
            });
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");
            });
        }
    }
}
