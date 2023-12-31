using Infrastructuur.Services.Classes;
using Infrastructuur.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLParserApi.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IServiceCollection UseConfiguration(this WebApplicationBuilder builder)
        {

            return builder.Services
                .GetScopes()
                .GetCors();
                 

        }
        private static IServiceCollection GetScopes(this IServiceCollection service)
        {
            return service.AddScoped<IHtmlParserService, HtmlParserService>();

        }
        private static IServiceCollection GetCors(this IServiceCollection service)
        {
            return service.AddCors(options =>
            {
                options.AddPolicy("AllowMultipleOrigins",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:7163", "https://localhost:7163")
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });
        }
    }
}
